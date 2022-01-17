using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfWincoverage.NetFramework.Login
{
    /// <summary>
    /// Lógica de interacción para ChangePass.xaml
    /// </summary>
    public partial class ChangePass : Page
    {
        public Frame MainFrame;
        public bool flag;
        public ChangePass(Frame Main, bool isForgotPass)
        {
            MainFrame = Main;
            flag = isForgotPass;
            InitializeComponent();
            if (flag)
            {
                labelCurrent.Visibility = Visibility.Visible;
                passBoxCurrent.Visibility = Visibility.Visible;
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Password changed", "Information");

            try
            {
               // MainFrame.Content = new LoginView(MainFrame, Application.Current.MainWindow);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
