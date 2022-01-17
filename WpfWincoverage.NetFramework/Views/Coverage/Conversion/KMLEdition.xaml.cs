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
using WpfWincoverage.NetFramework.Models;

namespace WpfWincoverage.NetFramework.Views.Coverage.Conversion
{
    /// <summary>
    /// Lógica de interacción para KMLEdition.xaml
    /// </summary>
    public partial class KMLEdition : Page
    {
        private Frame MainWin;
        public KMLEdition(Frame MainWin)
        {
            InitializeComponent();
            List<KMLedition> list = new List<KMLedition>();
            this.MainWin = MainWin;
            for (int i = 0; i < 2; i++)
            {
                KMLedition aux = new KMLedition();
                aux.From1 = "";
                aux.To1 = "";
                aux.Color1 = "";
                aux.From2 = "";
                aux.To2 = "";
                aux.Color2 = "";
                aux.From3 = "";
                aux.To3 = "";
                aux.Color3 = "";
                aux.From4 = "";
                aux.To4 = "";
                aux.Color4 = "";
                list.Add(aux);
            }

            dataGrid.ItemsSource = list;
            dataGrid.MinColumnWidth = 80;
            dataGrid.MinRowHeight = 20;
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
