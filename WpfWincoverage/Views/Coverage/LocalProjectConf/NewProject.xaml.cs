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
using WpfWincoverage.Models;

namespace WpfWincoverage.Views.Coverage.LocalProjectConf
{
    /// <summary>
    /// Lógica de interacción para NewProject.xaml
    /// </summary>
    public partial class NewProject : Page
    {
        public NewProject(Frame MainWin, bool isEdit)
        {
                        
            InitializeComponent();
            if (isEdit)
            {                
                labelMnj.Content = "Edit Project";           
            }

            List<ProjectCpeApModel> list = new List<ProjectCpeApModel>();

            for (int i = 0; i < 2; i++)
            {
                ProjectCpeApModel aux = new ProjectCpeApModel();
                aux.File_Protocol = "";
                aux.IP = "";
                aux.Subtel = "";
                aux.SNMP_User = "";
                aux.SNMP_Password = "";
                aux.SSID = "";
                list.Add(aux);
            }

            dataGridCPE.ItemsSource = list;
            dataGridAP.ItemsSource = list;

            dataGridAP.MinColumnWidth = 80;
            dataGridCPE.MinColumnWidth = 80;

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
        /*var w = Application.Current.Windows;
            WelcomeProfile welcomeProfile = new WelcomeProfile();
            welcomeProfile.Show();
            foreach (Window ww in w) ww.Close();*/


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            var w = Application.Current.Windows;
            WelcomeProfile welcomeProfile = new WelcomeProfile();
            welcomeProfile.Show();
            foreach (Window ww in w) ww.Close();
        }
        

    }
}
