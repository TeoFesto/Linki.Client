using Linki.SharedResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Linki.Client
{
    public static partial class ServerProvider
    {
        public static class ResponseHandler
        {
            public static async Task Handle(Response response)
            {
                string responseName = response.GetType().Name;
                string responseHandlerName = "Handle" + responseName;
                var ResponseHandlerType = typeof(ServerProvider.ResponseHandler);
                MethodInfo handler = ResponseHandlerType.GetMethod(responseHandlerName);
                await Task.Run(() =>
                {
                    handler.Invoke(null, new object[] { response });
                });
            }

            public static async Task HandleServerConnectionResponse(ServerConnectionResponse connectionResponse)
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

            public static async Task HandleSignUpResponse(SignUpResponse signUpResponse)
            {
                foreach (var form in Program.RunnedForms)
                {
                    if (form is SignUpForm signUpForm)
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
