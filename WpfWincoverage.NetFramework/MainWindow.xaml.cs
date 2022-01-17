using System;
using System.Diagnostics;
using System.Timers;
using System.Windows;

namespace WpfWincoverage.NetFramework
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string globalLanguage = "";
        public static string isLogin = "NO";
        public static Timer timerSession = new Timer();
        public static Timer timerSession2 = new Timer();
        public Action CloseAction { get; set; }

        public MainWindow()
        {
            
            //InitializeComponent();
            /* string language = "";
             try
             {

                 using (var connection = new SqliteConnection("Data Source=databaseLocal.db"))
                 {
                     connection.Open();
                     var command = connection.CreateCommand();

                     command.CommandText = "select language from configuracion limit 1";

                     using (var reader = command.ExecuteReader())
                     {
                         if (reader.HasRows)
                         {
                             if (reader.Read())
                             {
                                 language = reader.GetString(0);
                             }
                         }
                     }
                 }
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }
             if (language != "english" && language != "español")
                 globalLanguage = "english";
             else
                 globalLanguage = language;*/

            globalLanguage = "spanish";
            InitializeComponent();
            Main.Content = new Login.HomeView();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Login.LoginView(Main, Application.Current.MainWindow);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            const string message = "Thanks for using Wincoverage.";
            const string caption = "Attention";
            var result = MessageBox.Show(message, caption);
            Process[] runningProcesses = Process.GetProcesses();
            foreach (Process process in runningProcesses)
            {
                if (process.ProcessName.Contains("TcpBinding"))                
                    process.Kill();                
            }
            Close();

            //userBox.Visibility = Visibility.Visible;
        }
    }
}