using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfWincoverage.Models;

namespace WpfWincoverage
{
    /// <summary>
    /// Lógica de interacción para WelcomeProfile.xaml
    /// </summary>
    public partial class WelcomeProfile : Window
    {
        public static Timer timerSession = new Timer();
        public System.Windows.Threading.DispatcherTimer dispatcherTimer;

        public WelcomeProfile()
        {
            //timerSession = new Timer(10000); // fire every 1 second
            //timerSession.Elapsed += timerSession_Tick;
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(timerSession_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            //dispatcherTimer.Start();

            InitializeComponent();

            if (UserCurrentModel.rol == "inge")
            {
                configMenu.Items.Remove(userMenu);

            }
            if (UserCurrentModel.rol == "terre") 
            {
                configMenu.Items.Remove(userMenu);
                configMenu.Items.Remove(CPEMenu);
                configMenu.Items.Remove(GPSMenu);
                configMenu.Items.Remove(siteMenu);
                configMenu.Items.Remove(vectorMenu);
                configMenu.Items.Remove(channelMenu);
                winMenu.Items.Remove(converMenu);
                winMenu.Items.Remove(compaMenu);
            }
        }
        private void timerSession_Tick(object sender, EventArgs e)
        {
            const string message = "Your session expired.";
            const string caption = "Attention";
            var result = MessageBox.Show(message, caption);
            dispatcherTimer.Stop();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
            //InitializeComponent();
        }

        private async void userManagement_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            var users = await Database.DatabaseController.getUserList();
            Main.Content = new Configuration.UserManagement(Main, users);
        }

        private void CPEAP_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Configuration.cpeapManagement(Main);
        }

        private void Vector_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                imageMain2.Visibility = Visibility.Hidden;
                imageMain.Visibility = Visibility.Hidden;
                labelText.Visibility = Visibility.Hidden;
                button1.Visibility = Visibility.Hidden;
                button2.Visibility = Visibility.Hidden;
                button3.Visibility = Visibility.Hidden;
                Main.Content = new Views.Configuration.Vector.vectorPage(Main);
            }
            catch (Exception es) 
            {
                Console.WriteLine(es.Message);
            }            
        }
        private void GPS_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Configuration.GPS.gpsManagement(Main);
        }

        private void Site_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Configuration.Site.siteManagement(Main);
        }

        private void Channel_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Configuration.Channel.channelManagement(Main);
        }

        private void LocalCapture_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Coverage.LocalCapture.LocalCapture(Main);
        }

        private void DataloggerEx_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Coverage.DataLoggerEx.DataLoggerEx(Main);
        }

        private void Project_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Coverage.Project.Project(Main);
        }
        private void Vector2_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Coverage.Vector.Vector(Main);
        }

        private void ProjectConf_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Coverage.LocalProjectConf.LocalProjectConfig(Main);
        }

        private void DataloggerConf_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Coverage.DataLoggerConfig.DataLoggerConfig(Main);
        }

        private void XLS_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Coverage.Convertion.XLS(Main);
        }
        private void KML_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Coverage.Convertion.KML(Main);
        }
        private void XSLKML_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Coverage.Convertion.XLSKML(Main);
        }
        private void Share_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;
            imageMain.Visibility = Visibility.Hidden;
            labelText.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            Main.Content = new Views.Coverage.Share.Share(Main);
        }
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logout", "Logout");
            dispatcherTimer.Stop();

            var w = Application.Current.Windows;
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            foreach (Window ww in w) ww.Close();
        }
        private void menu_Click(object sender, RoutedEventArgs e) 
        {
            //reseTimer();
        }

        private void Canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Canvas canvas = sender as Canvas;
            SizeChangedEventArgs canvas_Changed_Args = e;
            if (canvas_Changed_Args.PreviousSize.Width == 0) return;

            double old_Height = canvas_Changed_Args.PreviousSize.Height;
            double new_Height = canvas_Changed_Args.NewSize.Height;
            double old_Width = canvas_Changed_Args.PreviousSize.Width;
            double new_Width = canvas_Changed_Args.NewSize.Width;

            double scale_Width = new_Width / old_Width;
            double scale_Height = new_Height / old_Height;

            foreach (FrameworkElement element in canvas.Children)
            {
                double old_Left = Canvas.GetLeft(element);
                double old_Top = Canvas.GetTop(element);

                Canvas.SetLeft(element, old_Left * scale_Width);
                Canvas.SetTop(element, old_Top * scale_Height);

                element.Width = element.Width * scale_Width;
                element.Height = element.Height * scale_Height;
            }
        }
        public void reseTimer()
        {
            dispatcherTimer.Stop();
            dispatcherTimer.Start();
        }
    }
}
