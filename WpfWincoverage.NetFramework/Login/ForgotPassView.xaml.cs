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

namespace WpfWincoverage.NetFramework.Login
{
    /// <summary>
    /// Lógica de interacción para ForgotPassView.xaml
    /// </summary>
    public partial class ForgotPassView : Page
    {
        public Frame MainFrame;
        public ForgotPassView(Frame Main)
        {
            MainFrame = Main;
            InitializeComponent();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //MainFrame.Content = new ChangePass(MainFrame, false);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
    }
}
