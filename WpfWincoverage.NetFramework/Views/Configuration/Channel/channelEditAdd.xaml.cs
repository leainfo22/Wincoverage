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

namespace WpfWincoverage.NetFramework.Views.Configuration.Channel
{
    /// <summary>
    /// Lógica de interacción para channelEditAdd.xaml
    /// </summary>
    public partial class channelEditAdd : Page
    {
        private Frame MainWin;
        private bool isEdit;
        Models.ChannelModel userMain;

        public channelEditAdd(Frame MainWin, bool isEdit, Models.ChannelModel user)
        {
            this.MainWin = MainWin;
            this.isEdit = isEdit;
            InitializeComponent();
            if (isEdit)
            {
                userMain = user;
                texboxName.Text = user.Channel;
                texboxArea.Text = user.FqzMedia;
                texboxLongitud.Text = user.Ancho;
                texboxLatitud.Text = user.BandaIni;
                texboxLatitud_Copy.Text = user.BandaFin;
                labelMnj.Content = "Edit Channel";
                saveNew.Visibility = Visibility.Hidden;
            }
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Models.SiteModel user = new Models.SiteModel();
            user.Name = texboxName.Text;
            user.Area = texboxArea.Text;
            user.Longitud = texboxLongitud.Text;
            user.Latitud = texboxLatitud.Text;

            /*if (isEdit)
            {
                Database.DatabaseController.updateSite(user, userMain.User, userMain.Name, userMain.Email);
            }
            else*/
            //Database.DatabaseController.addSite(user.Name, user.Area, user.Longitud, user.Latitud);


            var w = Application.Current.Windows;
            WelcomeProfile welcomeProfile = new WelcomeProfile();
            welcomeProfile.Show();
            foreach (Window ww in w) ww.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            texboxArea.Text = "";
            texboxName.Text = "";
            texboxLongitud.Text = "";
            texboxLatitud.Text = "";
        }
    }
}
