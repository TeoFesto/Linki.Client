using Linki.SharedResources;
using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Linki.Client
{
    internal static class Program
    {
        static Queue<Request> requests = new Queue<Request>();
        static Queue<Response> responses = new Queue<Response>();
        static TcpClient client = new TcpClient();

        static IPEndPoint serverConnectEndPoint;
        static IPEndPoint mainServerEndPoint = new IPEndPoint(IPAddress.Loopback, 8888);

        async public static void ConnectToServer(Label connectToServerStatusLabel)
        {
            try
            {
                await client.ConnectAsync(mainServerEndPoint);
                var stream = client.GetStream();
                connectToServerStatusLabel.ForeColor = Color.DarkGray;
                connectToServerStatusLabel.Text = "Ожидание подключения...";

                // буфер для получения данных
                var responseData = new byte[512];
                await stream.ReadAsync(responseData);
                string jsonResponse = Encoding.UTF8.GetString(responseData);

                Query response = JsonConvert.DeserializeObject<Query>(jsonResponse);
                Type responseType = Type.GetType(response.applicationMessageType);
                string serializedApplicationMessage = response.serializedApplicationMessage;
                object queryMessage = JsonConvert.DeserializeObject(serializedApplicationMessage, responseType);

                if (queryMessage is ServerConnectionResponse connectionResponse)
                {
                    try
                    {
                        serverConnectEndPoint = new IPEndPoint(IPAddress.Parse(connectionResponse.ipAddress), connectionResponse.port);
                        client.Close();
                        client = new TcpClient();
                        await client.ConnectAsync(serverConnectEndPoint);
                        connectToServerStatusLabel.ForeColor = Color.Green;
                        connectToServerStatusLabel.Text = "Подключение к серверу установлено";
                    }
                    catch(Exception ex)
                    {
                        connectToServerStatusLabel.ForeColor = Color.Red;
                        connectToServerStatusLabel.Text = "Не удалось подключиться к СВОЕМУ серверу";
                    }
                }
            }
            catch (Exception ex)
            {
                connectToServerStatusLabel.ForeColor = Color.Red;
                connectToServerStatusLabel.Text = "Не удалось подключиться к серверу";
            }
        }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthenticationForm());
        }

        static async Task SendRequests()
        {
            // В цикле while(true) отправляем каждый первый request в очередь requests
        }

        static async Task ReceiveResponses()
        {
            // В цикле while(true) принимаем и вставляем в responses каждый входящий response
        }

        static async Task HandleResponse()
        {
            // В цикле while(true) обрабатываем каждый первый response в очереди responses
        }


    }
}