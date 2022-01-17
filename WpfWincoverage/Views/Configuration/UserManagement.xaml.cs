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
using WpfWincoverage.Models;

namespace WpfWincoverage.Configuration
{
    /// <summary>
    /// Lógica de interacción para UserManagement.xaml
    /// </summary>
    public partial class UserManagement : Page
    {
        private Frame MainWin;

        public UserManagement(Frame MainWin,List<UserModel> users)
        {
            InitializeComponent();
            this.MainWin = MainWin;
            grid.ItemsSource = users;
            buttonDelete.IsEnabled = false;
            buttonEdit.IsEnabled = false;
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
            Models.UserModel user = new Models.UserModel();
            buttonEdit.Visibility = Visibility.Hidden;
            buttonDelete.Visibility = Visibility.Hidden;
            buttonNew.Visibility = Visibility.Hidden;
            labelUser.Visibility = Visibility.Hidden;
            grid.Visibility = Visibility.Hidden;
            imageLogo.Visibility = Visibility.Hidden;
            userFrame.Content = new NewUser(this.MainWin,false,user);
        }


        private void grid_Selected(object sender, RoutedEventArgs e)
        {
            buttonDelete.IsEnabled = true;
            buttonEdit.IsEnabled = true;
        }

        private async void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            UserModel user = (UserModel)grid.SelectedItem;
            string msj = string.Format("Are you sure to delete {0} ? ",user.Name);
            var result = MessageBox.Show(msj, "User remove",MessageBoxButton.OKCancel);

            
            if (result == MessageBoxResult.OK) 
            {
                await Database.DatabaseController.deleteUser(user.User,user.Name);
                grid.ItemsSource = await Database.DatabaseController.getUserList();

            }
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            UserModel user = (UserModel)grid.SelectedItem;
            buttonEdit.Visibility = Visibility.Hidden;
            buttonDelete.Visibility = Visibility.Hidden;
            buttonNew.Visibility = Visibility.Hidden;
            labelUser.Visibility = Visibility.Hidden;
            grid.Visibility = Visibility.Hidden;
            imageLogo.Visibility = Visibility.Hidden;
            userFrame.Content = new NewUser(this.MainWin, true,user);
        }
    }
}
