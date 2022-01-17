using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TpcBinding.Contracts;

namespace TcpBinding.Client
{
    public class Program
    {

        /*[DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;*/

        static void Main(string[] args)
        {
            //var handle = GetConsoleWindow();
            // Hide
            //ShowWindow(handle, SW_HIDE);
           
            Console.ReadLine();
        }
        public static List<List<string>> GetUsuarios() 
        {
            var uri = "net.tcp://localhost:4073/ServicioUsuario";
            var binding = new NetTcpBinding(SecurityMode.None);
            var channel = new ChannelFactory<IServiceUsuario>(binding);
            var endPoint = new EndpointAddress(uri);
            var proxy = channel.CreateChannel(endPoint);
            var lista = proxy?.GetUsuarios();
            return lista;
        }
    }
}
