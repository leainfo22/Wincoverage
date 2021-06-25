using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfWincoverage.Login
{
    /// <summary>
    /// Lógica de interacción para LoginView.xaml
    /// </summary>
    public partial class LoginView : Page
    {
        public Frame MainFrame;
        public Window windowHome;
        public LoginView(Frame Main, Window home)
        {
            MainFrame = Main;
            windowHome = home;
            InitializeComponent();
        }
    

        private void ForgotButton_Click(object sender, RoutedEventArgs e)
        {
            userBox.Visibility = Visibility.Hidden;
            passBox.Visibility = Visibility.Hidden;
            mensaje.Visibility = Visibility.Hidden;
            labelPass.Visibility = Visibility.Hidden;
            labelUser.Visibility = Visibility.Hidden;
            loginButton.Visibility = Visibility.Hidden;
            forgotButton.Visibility = Visibility.Hidden;
            buttonChange.Visibility = Visibility.Hidden;
            userBox.Visibility = Visibility.Visible;
            LoginFrame.Content = new ForgotPassView(MainFrame);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userBox.Visibility = Visibility.Hidden;
            passBox.Visibility = Visibility.Hidden;
            mensaje.Visibility = Visibility.Hidden;
            labelPass.Visibility = Visibility.Hidden;
            labelUser.Visibility = Visibility.Hidden;
            loginButton.Visibility = Visibility.Hidden;
            forgotButton.Visibility = Visibility.Hidden;
            buttonChange.Visibility = Visibility.Hidden;
            LoginFrame.Content = new ChangePass(MainFrame,true);

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            WelcomeProfile welcomeProfile = new WelcomeProfile();
            welcomeProfile.Show();
            windowHome.Close();
        }
    }
}
