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

namespace WpfWincoverage.Views.Configuration
{
    /// <summary>
    /// Lógica de interacción para cpeapManagement.xaml
    /// </summary>
    public partial class cpeapManagement : Page
    {
        public int coutCPE = 0;
        public int coutAP = 0;
        public int limit = 3;


        public cpeapManagement()
        {
            InitializeComponent();

            coutCPE = Database.DatabaseController.getCoutCPE();
            coutAP = Database.DatabaseController.getCoutAP();

            if(coutAP % limit == 0)
                labelAP.Content = coutAP/limit;
            else
                labelAP.Content =( coutAP / limit ) + 1;

            if (coutCPE % limit == 0)
                labelCPE.Content = coutCPE / limit;
            else
                labelCPE.Content = (coutCPE / limit) + 1;

            dataAP.ItemsSource = Database.DatabaseController.getAPList(3,0);
            dataCPE.ItemsSource = Database.DatabaseController.getCPEList(3,0);

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

    }
}
