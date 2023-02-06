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
        
        [STAThread]
        async static Task Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthenticationForm()); 
        }

        


    }
}