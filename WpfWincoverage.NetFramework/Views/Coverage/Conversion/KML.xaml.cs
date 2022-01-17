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

namespace WpfWincoverage.NetFramework.Views.Coverage.Conversion
{
    /// <summary>
    /// Lógica de interacción para KML.xaml
    /// </summary>
    public partial class KML : Page
    {
        private Frame Main;
        public KML(Frame Main)
        {
            this.Main = Main;
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
        private void KMLedition_Click(object sender, RoutedEventArgs e)
        {
            imageMain2.Visibility = Visibility.Hidden;

            labelMnj.Visibility = Visibility.Hidden;
            buttonClose.Visibility = Visibility.Hidden;
            buttonExit.Visibility = Visibility.Hidden;
            labelChannel.Visibility = Visibility.Hidden;
            labelPassword.Visibility = Visibility.Hidden;
            textBoxChannel.Visibility = Visibility.Hidden;
            textBoxPass.Visibility = Visibility.Hidden;
            labelPassword_Copy.Visibility = Visibility.Hidden;
            textBoxPass_Copy.Visibility = Visibility.Hidden;
            buttonClose_Copy.Visibility = Visibility.Hidden;
            labelMnj_Copy.Visibility = Visibility.Hidden;

            Main.Content = new Views.Coverage.Conversion.KMLEdition(Main);
        }

    }
}
