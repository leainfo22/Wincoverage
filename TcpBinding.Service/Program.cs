using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpcBinding.Contracts;
using System.ServiceModel;

namespace TcpBinding.Service
{
    class Program
    {

        /*[DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;*/

        static void Main(string[] args)
        {
           // var handle = GetConsoleWindow();
           // Hide
           //ShowWindow(handle, SW_HIDE);

            var uris = new Uri[1];
            string addr = "net.tcp://localhost:4073/ServicioUsuario";
            uris[0] = new Uri(addr);
            IServiceUsuario serviceUsuario = new ServicioUsuario();
            ServiceHost host = new ServiceHost(serviceUsuario,uris);
            var binding = new NetTcpBinding(SecurityMode.None);
            host.AddServiceEndpoint(typeof(IServiceUsuario), binding, "");
            host.Opened += Host_Opened;
            host.Open();
            Console.ReadLine();
        }

        private static void Host_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("SERVICIO INICIADO.");
        }
    }
}
