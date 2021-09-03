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
        private Frame MainWin;
        string type;   

        public cpeapManagement(Frame MainWin)
        {
            InitializeComponent();
            this.type = "";
            this.MainWin = MainWin;
            buttonEdit.IsEnabled = false;
            coutCPE = Database.DatabaseController.getCoutCPE();
            coutAP = Database.DatabaseController.getCoutAP();
            try
            {
                if (coutAP % limit == 0)
                    labelAP.Content = coutAP / limit;
                else
                    labelAP.Content = (coutAP / limit) + 1;

                if (coutCPE % limit == 0)
                    labelCPE.Content = coutCPE / limit;
                else
                    labelCPE.Content = (coutCPE / limit) + 1;

                if (labelCPE.Content.ToString() == boxCPE.Text)
                    bottonCPENext.IsEnabled = false;
                if (labelAP.Content.ToString() == boxAP.Text)
                    bottonAPNext.IsEnabled = false;

                if ("1" == boxCPE.Text)
                    bottonCPEBefore.IsEnabled = false;
                if ("1" == boxAP.Text)
                    bottonAPBefore.IsEnabled = false;


                dataAP.ItemsSource = Database.DatabaseController.getAPList(3, 0);
                dataCPE.ItemsSource = Database.DatabaseController.getCPEList(3, 0);
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
            if (dataCPE.SelectedItem != null)
            {
                user = (Models.CPEAModel)dataCPE.SelectedItem;
                CPEflag = true;
            }

            string msj = string.Format("Are you sure to delete {0} ? ", user.Code);
            var result = MessageBox.Show(msj, "User remove", MessageBoxButton.OKCancel);


            if (result == MessageBoxResult.OK)
            {
                Database.DatabaseController.deleteCPEAP(user.Code);
                if(APflag)
                    dataAP.ItemsSource = Database.DatabaseController.getUserList();
                if(CPEflag)
                    dataCPE.ItemsSource = Database.DatabaseController.getUserList();

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
            if (dataCPE.SelectedItem != null)
            {
                user = (Models.CPEAModel)dataCPE.SelectedItem;
                type = "CPE";
            }

            labelMnj.Visibility = Visibility.Hidden;
            dataAP.Visibility = Visibility.Hidden;
            dataCPE.Visibility = Visibility.Hidden;
            labelListAP.Visibility = Visibility.Hidden;
            labelListCPE.Visibility = Visibility.Hidden;
            buttonADDAP.Visibility = Visibility.Hidden;
            buttonADDCPE.Visibility = Visibility.Hidden;
            buttonEdit.Visibility = Visibility.Hidden;
            buttonDelete.Visibility = Visibility.Hidden;
            buttonImport.Visibility = Visibility.Hidden;
            buttonViz.Visibility = Visibility.Hidden;
            labelAP.Visibility = Visibility.Hidden;
            labelDeAP.Visibility = Visibility.Hidden;
            bottonAPNext.Visibility = Visibility.Hidden;
            bottonAPBefore.Visibility = Visibility.Hidden;
            labelCPE.Visibility = Visibility.Hidden;
            labelDeCPE.Visibility = Visibility.Hidden;
            bottonCPENext.Visibility = Visibility.Hidden;
            bottonCPEBefore.Visibility = Visibility.Hidden;
            boxAP.Visibility = Visibility.Hidden;
            boxCPE.Visibility = Visibility.Hidden;            

            userFrame.Content = new cpeapEditAdd(this.MainWin, true, user,type);
        }
        private void buttonAddAP_Click(object sender, RoutedEventArgs e)
        {
            Models.CPEAModel user = new Models.CPEAModel();
          
            type = "AP";

            labelMnj.Visibility = Visibility.Hidden;
            dataAP.Visibility = Visibility.Hidden;
            dataCPE.Visibility = Visibility.Hidden;
            labelListAP.Visibility = Visibility.Hidden;
            labelListCPE.Visibility = Visibility.Hidden;
            buttonADDAP.Visibility = Visibility.Hidden;
            buttonADDCPE.Visibility = Visibility.Hidden;
            buttonEdit.Visibility = Visibility.Hidden;
            buttonDelete.Visibility = Visibility.Hidden;
            buttonImport.Visibility = Visibility.Hidden;
            buttonViz.Visibility = Visibility.Hidden;
            labelAP.Visibility = Visibility.Hidden;
            labelDeAP.Visibility = Visibility.Hidden;
            bottonAPNext.Visibility = Visibility.Hidden;
            bottonAPBefore.Visibility = Visibility.Hidden;
            labelCPE.Visibility = Visibility.Hidden;
            labelDeCPE.Visibility = Visibility.Hidden;
            bottonCPENext.Visibility = Visibility.Hidden;
            bottonCPEBefore.Visibility = Visibility.Hidden;
            boxAP.Visibility = Visibility.Hidden;
            boxCPE.Visibility = Visibility.Hidden;

            userFrame.Content = new cpeapEditAdd(this.MainWin, false, user,type);
        }
        private void buttonAddCPE_Click(object sender, RoutedEventArgs e)
        {
            Models.CPEAModel user = new Models.CPEAModel();

            type = "CPE";

            labelMnj.Visibility = Visibility.Hidden;
            dataAP.Visibility = Visibility.Hidden;
            dataCPE.Visibility = Visibility.Hidden;
            labelListAP.Visibility = Visibility.Hidden;
            labelListCPE.Visibility = Visibility.Hidden;
            buttonADDAP.Visibility = Visibility.Hidden;
            buttonADDCPE.Visibility = Visibility.Hidden;
            buttonEdit.Visibility = Visibility.Hidden;
            buttonDelete.Visibility = Visibility.Hidden;
            buttonImport.Visibility = Visibility.Hidden;
            buttonViz.Visibility = Visibility.Hidden;
            labelAP.Visibility = Visibility.Hidden;
            labelDeAP.Visibility = Visibility.Hidden;
            bottonAPNext.Visibility = Visibility.Hidden;
            bottonAPBefore.Visibility = Visibility.Hidden;
            labelCPE.Visibility = Visibility.Hidden;
            labelDeCPE.Visibility = Visibility.Hidden;
            bottonCPENext.Visibility = Visibility.Hidden;
            bottonCPEBefore.Visibility = Visibility.Hidden;
            boxAP.Visibility = Visibility.Hidden;
            boxCPE.Visibility = Visibility.Hidden;

            userFrame.Content = new cpeapEditAdd(this.MainWin, false, user, type);
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
        private void Button_NextCPE(object sender, RoutedEventArgs e)
        {
            try
            {
                dataCPE.ItemsSource = Database.DatabaseController.getCPEList(limit, limit * Int32.Parse(boxCPE.Text));
                boxCPE.Text = (Int32.Parse(boxCPE.Text.ToString()) + 1).ToString();

                if (labelCPE.Content.ToString() == boxCPE.Text)
                    bottonCPENext.IsEnabled = false;
                else
                    bottonCPENext.IsEnabled = true;

                if ("1" == boxCPE.Text)
                    bottonCPEBefore.IsEnabled = false;
                else
                    bottonCPEBefore.IsEnabled = true;

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
                dataAP.ItemsSource = Database.DatabaseController.getAPList(limit, limit * ((Int32.Parse(boxAP.Text)-1)-limit));
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
        private void Button_BeforeCPE(object sender, RoutedEventArgs e)
        {
            try
            {
                dataCPE.ItemsSource = Database.DatabaseController.getAPList(limit, limit * ((Int32.Parse(boxCPE.Text)-1)-limit));
                boxCPE.Text = (Int32.Parse(boxCPE.Text.ToString()) - 1).ToString();
                if ("1" == boxCPE.Text)
                    bottonCPEBefore.IsEnabled = false;
                else
                    bottonCPEBefore.IsEnabled = true;

                if (labelCPE.Content.ToString() == boxCPE.Text)
                    bottonCPENext.IsEnabled = false;
                else
                    bottonCPENext.IsEnabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
