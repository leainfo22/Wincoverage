using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfWincoverage.NetFramework.Views.Coverage.DataLoggerConfig
{
    /// <summary>
    /// Lógica de interacción para DataLoggerConfig.xaml
    /// </summary>
    public partial class DataLoggerConfig : Page
    {
        Frame MainWin;
        public DataLoggerConfig(Frame MainWin)
        {
            this.MainWin = MainWin;
            InitializeComponent();
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
        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {

            dataGrid.Visibility = Visibility.Hidden;
            buttonADDAP.Visibility = Visibility.Hidden;
            buttonEdit.Visibility = Visibility.Hidden;
            buttonDelete.Visibility = Visibility.Hidden;
            buttonImport.Visibility = Visibility.Hidden;
            labelMnj.Visibility = Visibility.Hidden;
            imageMain2.Visibility = Visibility.Hidden;
            buttonConf.Visibility = Visibility.Hidden;
            button.Visibility = Visibility.Hidden;

            userFrame.Content = new NewDataLoggerConfig(this.MainWin, true);
        }

        private void buttonNew_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Visibility = Visibility.Hidden;
            buttonADDAP.Visibility = Visibility.Hidden;
            buttonEdit.Visibility = Visibility.Hidden;
            buttonDelete.Visibility = Visibility.Hidden;
            buttonImport.Visibility = Visibility.Hidden;
            labelMnj.Visibility = Visibility.Hidden;
            imageMain2.Visibility = Visibility.Hidden;
            buttonConf.Visibility = Visibility.Hidden;
            button.Visibility = Visibility.Hidden;
            userFrame.Content = new NewDataLoggerConfig(this.MainWin, false);
        }

        private void buttonImport_Click(object sender, RoutedEventArgs e)
        {
            string path = "";
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                path = File.ReadAllText(openFileDialog.FileName);
        }

        private void grid_Selected(object sender, RoutedEventArgs e)
        {
            buttonDelete.IsEnabled = true;
            buttonEdit.IsEnabled = true;
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            string msj = string.Format("Are you sure to delete the project ? ");
            var result = MessageBox.Show(msj, "User remove", MessageBoxButton.OKCancel);


            if (result == MessageBoxResult.OK)
            {
                var w = Application.Current.Windows;
                WelcomeProfile welcomeProfile = new WelcomeProfile();
                welcomeProfile.Show();
                foreach (Window ww in w) ww.Close();

            }
        }
        private void buttonConfig_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.Visibility = Visibility.Hidden;
            buttonADDAP.Visibility = Visibility.Hidden;
            buttonEdit.Visibility = Visibility.Hidden;
            buttonDelete.Visibility = Visibility.Hidden;
            buttonImport.Visibility = Visibility.Hidden;
            labelMnj.Visibility = Visibility.Hidden;
            imageMain2.Visibility = Visibility.Hidden;
            buttonConf.Visibility = Visibility.Hidden;
            button.Visibility = Visibility.Hidden;
            userFrame.Content = new ProjectoConfigInDatalogger(this.MainWin);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            var w = Application.Current.Windows;
            WelcomeProfile welcomeProfile = new WelcomeProfile();
            welcomeProfile.Show();
            foreach (Window ww in w) ww.Close();
        }

    }

}
