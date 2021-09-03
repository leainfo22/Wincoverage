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
using WpfWincoverage.Models;

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

        private void ButtonChange_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userBox.Text))
                MessageBox.Show("Complete user information", "Information");
            else if (string.IsNullOrEmpty(passBox.Password))
                MessageBox.Show("Complete password information", "Information");
            else 
            {
                userBox.Visibility = Visibility.Hidden;
                passBox.Visibility = Visibility.Hidden;
                mensaje.Visibility = Visibility.Hidden;
                labelPass.Visibility = Visibility.Hidden;
                labelUser.Visibility = Visibility.Hidden;
                loginButton.Visibility = Visibility.Hidden;
                forgotButton.Visibility = Visibility.Hidden;
                buttonChange.Visibility = Visibility.Hidden;
                LoginFrame.Content = new ChangePass(MainFrame, true);
            }          

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(userBox.Text))
                MessageBox.Show("Complete user information", "Information");
            else if (string.IsNullOrEmpty(passBox.Password))
                MessageBox.Show("Complete password information", "Information");
            else
            {
                if (userBox.Text == "admin")
                    UserCurrentModel.rol = userBox.Text;    
                if (userBox.Text == "terre")
                    UserCurrentModel.rol = userBox.Text;
                if (userBox.Text == "inge")
                    UserCurrentModel.rol = userBox.Text;
                //cambiar para sacar los privilegios a cualquiera **lvasquez
                else
                    UserCurrentModel.rol = userBox.Text;

                var w = Application.Current.Windows;
                WelcomeProfile welcomeProfile = new WelcomeProfile();
                welcomeProfile.Show();
                foreach (Window ww in w) ww.Close();
            }
        }
    }
}
