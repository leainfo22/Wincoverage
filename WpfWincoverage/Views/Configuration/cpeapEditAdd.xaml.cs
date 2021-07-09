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
    /// Lógica de interacción para cpeapEditAdd.xaml
    /// </summary>
    public partial class cpeapEditAdd : Page
    {
        private int  limit = 3;
        private int coutFamily = 0;

        public cpeapEditAdd(Frame MainWin, bool isEdit, Models.CPEAModel user)
        {
            InitializeComponent();
            coutFamily = Database.DatabaseController.getCoutFamily();
            try
            {
                if (coutFamily % limit == 0)
                    labelAP.Content = coutFamily / limit;
                else
                    labelAP.Content = (coutFamily / limit) + 1;


                if (labelAP.Content.ToString() == boxAP.Text)
                    bottonNext.IsEnabled = false;

                if ("1" == boxAP.Text)
                    bottonBefore.IsEnabled = false;

                if (isEdit) 
                {
                    box1.Text = user.Brand;
                    box2.Text = user.Model;
                    box3.Text = user.Code;
                    box4.Text = user.Firmware;
                }

                dataFamily.ItemsSource = Database.DatabaseController.getFamilyList(limit, 0);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Button_NextAP(object sender, RoutedEventArgs e)
        {
            try
            {
                dataFamily.ItemsSource = Database.DatabaseController.getFamilyList(limit, limit * Int32.Parse(boxAP.Text));
                boxAP.Text = (Int32.Parse(boxAP.Text.ToString()) + 1).ToString();

                if (labelAP.Content.ToString() == boxAP.Text)
                    bottonNext.IsEnabled = false;
                else
                    bottonNext.IsEnabled = true;

                if ("1" == boxAP.Text)
                    bottonBefore.IsEnabled = false;
                else
                    bottonBefore.IsEnabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Button_BeforeAP(object sender, RoutedEventArgs e)
        {
            try
            {
                dataFamily.ItemsSource = Database.DatabaseController.getFamilyList(limit, limit * ((Int32.Parse(boxAP.Text) - 1) - limit));
                boxAP.Text = (Int32.Parse(boxAP.Text.ToString()) - 1).ToString();
                if ("1" == boxAP.Text)
                    bottonBefore.IsEnabled = false;
                else
                    bottonBefore.IsEnabled = true;

                if (labelAP.Content.ToString() == boxAP.Text)
                    bottonNext.IsEnabled = false;
                else
                    bottonNext.IsEnabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
