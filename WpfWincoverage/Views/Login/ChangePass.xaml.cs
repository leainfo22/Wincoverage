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
    /// Lógica de interacción para ChangePass.xaml
    /// </summary>
    public partial class ChangePass : Page
    {

        public Frame MainFrame;
        public bool flag;
        public ChangePass(Frame Main,bool isForgotPass)
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
                MainFrame.Content = new LoginView(MainFrame,Application.Current.MainWindow);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
