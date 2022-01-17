using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace Launcher
{
    class Program
    {

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        static void Main(string[] args)
        {


            var handle = GetConsoleWindow();
            // Hide
            ShowWindow(handle, SW_HIDE);
            ProcessStartInfo startInfo1 = new ProcessStartInfo();
            string path = Directory.GetCurrentDirectory();
            startInfo1.FileName = path + "\\WpfWincoverage\\WpfWincoverage.NetFramework.exe";
            Process.Start(startInfo1);

            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            startInfo2.FileName = path + "\\TcpClient\\TcpBinding.Client.exe";
            Process.Start(startInfo2); 

            ProcessStartInfo startInfo3 = new ProcessStartInfo();
            startInfo3.FileName = path + "\\TcpService\\TcpBinding.Service.exe";
            Process.Start(startInfo3);

            // Show
            //ShowWindow(handle, SW_SHOW);

        }
    }
}
