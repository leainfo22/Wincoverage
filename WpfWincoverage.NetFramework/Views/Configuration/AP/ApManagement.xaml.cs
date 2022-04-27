using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
using WpfWincoverage.NetFramework.Models;

namespace WpfWincoverage.NetFramework.Views.Configuration.AP
{
    /// <summary>
    /// Lógica de interacción para ApManagement.xaml
    /// </summary>
    public partial class ApManagement : Page
    {
        public int coutCPE = 0;
        public int coutAP = 0;
        public int limit = 3;
        private Frame MainWin;
        string type;

        public ApManagement(Frame MainWin, Uri uri)
        {
            ResourceDictionary dictionary = new ResourceDictionary();
            dictionary.Source = uri;
            this.Resources.MergedDictionaries.Add(dictionary);
            InitializeComponent();
            this.type = "";
            this.MainWin = MainWin;
            buttonEdit.IsEnabled = false;
            coutAP = Database.DatabaseController.getCoutAP();
            try
            {
                if (coutAP % limit == 0)
                    labelAP.Content = coutAP / limit;
                else
                    labelAP.Content = (coutAP / limit) + 1;
             
                if (labelAP.Content.ToString() == boxAP.Text)
                    bottonAPNext.IsEnabled = false;

                if ("1" == boxAP.Text)
                    bottonAPBefore.IsEnabled = false;

                dataAP.ItemsSource = Database.DatabaseController.getAPList(3, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
        private void grid_Selected(object sender, RoutedEventArgs e)
        {
            buttonDelete.IsEnabled = true;
            buttonEdit.IsEnabled = true;
        }
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            Models.CPEAModel user = new Models.CPEAModel();
            bool APflag = false;
            bool CPEflag = false;

            if (dataAP.SelectedItem != null)
            {
                user = (Models.CPEAModel)dataAP.SelectedItem;
                APflag = true;
            }
          
            string msj = string.Format("Are you sure to delete {0} ? ", user.Code);
            var result = MessageBox.Show(msj, "User remove", MessageBoxButton.OKCancel);


            if (result == MessageBoxResult.OK)
            {
                Database.DatabaseController.deleteCPEAP(user.Code);
                if (APflag)
                    dataAP.ItemsSource = Database.DatabaseController.getUserList();
              

                var w = Application.Current.Windows;
                WelcomeProfile welcomeProfile = new WelcomeProfile();
                welcomeProfile.Show();
                foreach (Window ww in w) ww.Close();

            }
        }
        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            Models.CPEAModel user = new Models.CPEAModel();
            if (dataAP.SelectedItem != null)
            {
                user = (Models.CPEAModel)dataAP.SelectedItem;
                type = "AP";
            }
        

            labelMnj.Visibility = Visibility.Hidden;
            dataAP.Visibility = Visibility.Hidden;
            labelListAP.Visibility = Visibility.Hidden;
            buttonADDAP.Visibility = Visibility.Hidden;
            buttonEdit.Visibility = Visibility.Hidden;
            buttonDelete.Visibility = Visibility.Hidden;
            buttonImport.Visibility = Visibility.Hidden;
            buttonViz.Visibility = Visibility.Hidden;
            labelAP.Visibility = Visibility.Hidden;
            labelDeAP.Visibility = Visibility.Hidden;
            bottonAPNext.Visibility = Visibility.Hidden;
            bottonAPBefore.Visibility = Visibility.Hidden;         
            boxAP.Visibility = Visibility.Hidden;
            button.Visibility = Visibility.Hidden;

            userFrame.Content = new ApEditAdd(this.MainWin, true, user, type);
        }
        private void buttonAddAP_Click(object sender, RoutedEventArgs e)
        {
            Models.CPEAModel user = new Models.CPEAModel();

            type = "AP";

            labelMnj.Visibility = Visibility.Hidden;
            dataAP.Visibility = Visibility.Hidden;
            labelListAP.Visibility = Visibility.Hidden;
            buttonADDAP.Visibility = Visibility.Hidden;
            buttonEdit.Visibility = Visibility.Hidden;
            buttonDelete.Visibility = Visibility.Hidden;
            buttonImport.Visibility = Visibility.Hidden;
            buttonViz.Visibility = Visibility.Hidden;
            labelAP.Visibility = Visibility.Hidden;
            labelDeAP.Visibility = Visibility.Hidden;
            bottonAPNext.Visibility = Visibility.Hidden;
            bottonAPBefore.Visibility = Visibility.Hidden;            
            boxAP.Visibility = Visibility.Hidden;
            button.Visibility = Visibility.Hidden;

            userFrame.Content = new ApEditAdd(this.MainWin, false, user, type);
        }
        private void buttonImport_Click(object sender, RoutedEventArgs e)
        {
            string path = "";
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                path = File.ReadAllText(openFileDialog.FileName);
        }
        private void Button_NextAP(object sender, RoutedEventArgs e)
        {
            try
            {
                dataAP.ItemsSource = Database.DatabaseController.getAPList(limit, limit * Int32.Parse(boxAP.Text));
                boxAP.Text = (Int32.Parse(boxAP.Text.ToString()) + 1).ToString();

                if (labelAP.Content.ToString() == boxAP.Text)
                    bottonAPNext.IsEnabled = false;
                else
                    bottonAPNext.IsEnabled = true;

                if ("1" == boxAP.Text)
                    bottonAPBefore.IsEnabled = false;
                else
                    bottonAPBefore.IsEnabled = true;
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
                dataAP.ItemsSource = Database.DatabaseController.getAPList(limit, limit * ((Int32.Parse(boxAP.Text) - 1) - limit));
                boxAP.Text = (Int32.Parse(boxAP.Text.ToString()) - 1).ToString();
                if ("1" == boxAP.Text)
                    bottonAPBefore.IsEnabled = false;
                else
                    bottonAPBefore.IsEnabled = true;

                if (labelAP.Content.ToString() == boxAP.Text)
                    bottonAPNext.IsEnabled = false;
                else
                    bottonAPNext.IsEnabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
