using System.Windows;
using System.Windows.Controls;
using WpfWincoverage.NetFramework.Models;

namespace WpfWincoverage.NetFramework.Login
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
            InitializeComponent();
            MainFrame = Main;
            windowHome = home;
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
                //LoginFrame.Content = new ChangePass(MainFrame, true);
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
                {
                    UserCurrentModel.name = userBox.Text;
                    UserCurrentModel.rol = userBox.Text;

                }
                else if (userBox.Text == "terre") 
                {
                    UserCurrentModel.name = userBox.Text;
                    UserCurrentModel.rol = "Terreno";
                }
                else if (userBox.Text == "inge")
                {
                    UserCurrentModel.rol = "Ingeniero";
                    UserCurrentModel.name = userBox.Text;

                }
                //cambiar para sacar los privilegios a cualquiera **lvasquez
                //else 
                //{
                //    UserCurrentModel.name = userBox.Text;
                //    UserCurrentModel.rol = "Administrador";
                //}

                var w = Application.Current.Windows;
                WelcomeProfile welcomeProfile = new WelcomeProfile();
                welcomeProfile.Show();
                foreach (Window ww in w) ww.Close();
            }
        }
    }
}
