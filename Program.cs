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
        public static List<Form> RunnedForms { get; set; } = new List<Form>();


        [STAThread]
        async static Task Main()
        {
            //string folderName = "MyFolder";
            //string path = Path.Combine(Directory.GetCurrentDirectory(), folderName);

            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}
            

            ApplicationConfiguration.Initialize();
            Application.Run(new AuthenticationForm()); 
        }

    }
}