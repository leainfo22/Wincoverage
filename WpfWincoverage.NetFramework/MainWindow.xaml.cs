using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
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
        public static ResourceDictionary dictionary = new ResourceDictionary();

        public Action CloseAction { get; set; }

        public MainWindow()
        {            
            //InitializeComponent();
             string language = "";
             try
             {
                 using (var connection = new SQLiteConnection("Data Source=databaseLocal.db"))
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
             if (language != "English" && language != "Español" && language != "Portugues")
                 globalLanguage = "English";
             else
                 globalLanguage = language;

            SwitchLanguage(globalLanguage);
            
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
            
        public void SwitchLanguage(string language)
        {   
            Resources.MergedDictionaries.Clear();
            try
            {
                switch (language)
                {
                    case "English":
                        dictionary.Source = new Uri(Directory.GetCurrentDirectory() + "\\StringDictionary.en.xaml", UriKind.Absolute);
                        break;

                    case "Español":
                        dictionary.Source = new Uri(Directory.GetCurrentDirectory() + "\\StringDictionary.es.xaml", UriKind.Absolute);

                        break;

                    case "Portugues":
                        dictionary.Source = new Uri(Directory.GetCurrentDirectory() + "\\StringDictionary.po.xaml", UriKind.Absolute);

                        break;

                    default:
                        dictionary.Source = new Uri(Directory.GetCurrentDirectory() + "\\StringDictionary.en.xaml", UriKind.Absolute);
                        break;
                }
                Resources.MergedDictionaries.Add(dictionary);
            }
            catch (Exception ex) 
            {
                var message = ex.Message;
            }
            
        }
    }
}