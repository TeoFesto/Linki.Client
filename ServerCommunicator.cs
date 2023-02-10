using Linki.SharedResources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Linki.Client
{
    public static class ServerCommunicator
    {
        private static Queue<Request> requests = new Queue<Request>();
        private static Queue<Response> responses = new Queue<Response>();
        private static TcpClient client = new TcpClient();
        private static IPEndPoint mainServerEndPoint = new IPEndPoint(IPAddress.Loopback, 8888);
        private static IPEndPoint? personalServerEndPoint = null;
        private static List<Label> connectionLabels = new List<Label>();

        public static void AddConnectionLabel(Label label)
        {
            connectionLabels.Add(label);
        }

        public static void AddRequest(Request request)
        {
            requests.Enqueue(request);
        }

        private static void ResetClient()
        {
            client.Close();
            client = new TcpClient();
        }
        public static void UpdateConnectionLabels(string labelText, Color color)
        {
            foreach (var label in connectionLabels)
            {
                label.Invoke(() =>
                {
                    label.Text = labelText;
                    label.ForeColor = color;
                });
            }
        }

        public static bool IsClientConnectedToPersonalServer()
        {
            if (client.Client.RemoteEndPoint == null)
                return false;

            bool doesPersonalServerEndPointExist = (personalServerEndPoint != null);
            string? personalEndPointString = personalServerEndPoint?.ToString();

            IPAddress IPv4AddressRemoteEndPoint = ((IPEndPoint)client.Client.RemoteEndPoint).Address.MapToIPv4();
            int portRemoteEndPoint = ((IPEndPoint)client.Client.RemoteEndPoint).Port;
            IPEndPoint? remoteIPEndPoint = new IPEndPoint(IPv4AddressRemoteEndPoint, portRemoteEndPoint);
            string? clientRemoteEndPointString = remoteIPEndPoint?.ToString();


            bool isClientConnectedToPersonalServer = (personalEndPointString == clientRemoteEndPointString) && (client.Connected);
            if(doesPersonalServerEndPointExist && isClientConnectedToPersonalServer)
            {
                bool isPersonalServerAvailable = !client.Client.Poll(10, SelectMode.SelectRead);
                if (isPersonalServerAvailable)
                    return true;
            }
            return false;
        }

        async public static Task CheckConnectionToServer()
        {
            while (true)
            {
                if (IsClientConnectedToPersonalServer())
                {
                    Thread.Sleep(5000);
                    continue;
                }
                else
                {
                    personalServerEndPoint = null;
                    int tryCount = 0;
                    while (true)
                    {
                        tryCount++;
                        UpdateConnectionLabels($"Попытка #{tryCount} подключения к серверу...", Color.DarkSlateGray);
                        Thread.Sleep(2000);
                        await ConnectToServerAsync();
                        if (IsClientConnectedToPersonalServer())
                        {
                            UpdateConnectionLabels("Подключение к серверу установлено", Color.Green);
                            break;
                        }
                        else
                        {
                            UpdateConnectionLabels("Не удалось подключиться к серверу", Color.DarkRed);
                            Thread.Sleep(2000);
                        }
                    }
                }
            }                                                                                                  
        }                                                                                                      
                                                                                                               
        async public static Task ConnectToServerAsync()
        {
            try
            {
                ResetClient();
                await client.ConnectAsync(mainServerEndPoint);
                Thread.Sleep(3000);
                if (IsClientConnectedToPersonalServer())
                    return;
                
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                double waitSeconds = 30;
                while (true) 
                {
                    if (IsClientConnectedToPersonalServer())
                        break;
                    
                    if (stopwatch.ElapsedMilliseconds <= waitSeconds * 1000)
                    {
                        double secondsBeforeNextTry = (waitSeconds * 1000 - stopwatch.ElapsedMilliseconds) / 1000;
                        UpdateConnectionLabels($"Ждем подключения... \nСледующая попытка через " +
                            $"{Math.Round(secondsBeforeNextTry,2)} секунд", Color.DarkGray);
                    }
                    else
                    {
                        stopwatch.Stop();
                        break;
                    }
                }
            }
            catch (SocketException ex)
            {
                //написать логирование потом
            }
        }


        public static async Task SendRequests()
        {
            while (true)
            {
               if (requests.Count != 0)
               {
                   try
                   {
                       Request request = requests.Dequeue();
                       string jsonRequest = QueryJsonConverter.SerializeQueryMessage(request) + "\n";
                       byte[] data = Encoding.UTF8.GetBytes(jsonRequest);
                       await client.Client.SendAsync(data, SocketFlags.None);
                   }
                   catch(Exception ex)
                   {
                        
                   }
               }
            }
        }


        public static async Task ReceiveResponses()
        {
            List<byte> bytes = new List<byte>();
            string jsonResponseQuery;
            Response response = new Response();
            while (true)
            {
                try
                {
                    byte[] bufferByte = new byte[1];
                    await client.Client.ReceiveAsync(bufferByte, SocketFlags.None);
                    char c = (char)bufferByte[0];
                    if (c != '\n')
                    {
                        bytes.Add(bufferByte[0]);
                    }
                    else
                    {
                        jsonResponseQuery = Encoding.UTF8.GetString(bytes.ToArray());
                        bytes.Clear();
                        response = (Response)QueryJsonConverter.DeserializeQuery(jsonResponseQuery);
                        responses.Enqueue(response);
                    }
                }   

                catch (Exception ex)
                {

                }
            }
        }

        public static async Task HandleResponses()
        {
            while (true)
            {
                if(responses.Count != 0)
                {
                    Response response = responses.Dequeue();
                    if(response is ServerConnectionResponse connectionResponse)
                    {
                        try
                        {
                            personalServerEndPoint = new IPEndPoint(IPAddress.Parse(connectionResponse.ipAddress), connectionResponse.port);
                            string confirmMessage = "CONFIRM ENDPOINT\n";
                            byte[] data = Encoding.UTF8.GetBytes(confirmMessage);
                            await client.Client.SendAsync(data, SocketFlags.None);
                            ResetClient();
                            await client.ConnectAsync(personalServerEndPoint);
                        }
                        catch (Exception ex)
                        {
                            ResetClient();
                        }
                    }
                    else if(response is SignUpResponse signUpResponse)
                    {
                        foreach(var form in Program.RunnedForms)
                        {
                            if(form is SignUpForm signUpForm)
                            {
                                signUpForm.signUpStatusLabel.Invoke(() =>
                                {
                                    signUpForm.signUpStatusLabel.Text = signUpResponse.StatusMessage;

                                });

                                signUpForm.signUpStatusLabel.Invoke(() =>
                                {
                                    if (signUpResponse.isSignedUp)
                                        signUpForm.signUpStatusLabel.ForeColor = Color.Green;
                                    else
                                        signUpForm.signUpStatusLabel.ForeColor = Color.Red;
                                });
                            }
                        }
                    }
                }
            }
        }
    }
}
