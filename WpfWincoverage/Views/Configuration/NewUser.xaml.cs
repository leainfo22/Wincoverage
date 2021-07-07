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

namespace WpfWincoverage.Configuration
{
    /// <summary>
    /// Lógica de interacción para NewUser.xaml
    /// </summary>
    public partial class NewUser : Page
    {
        private Frame MainWin;
        private bool isEdit;
        Models.UserModel userMain;

        public NewUser(Frame MainWin, bool isEdit,Models.UserModel user)
        {
            this.MainWin = MainWin;
            this.isEdit = isEdit;
            InitializeComponent();
            if (isEdit) 
            {
                userMain = user;
                texboxUser.Text = user.User;
                texboxName.Text = user.Name;
                texboxPhone.Text = user.Phone;
                texboxCharge.Text = user.Charge;
                texboxEmail.Text = user.Email;
                comboBox.Text = user.Rol;
                labelMnj.Content = "Edit User";
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
           
            Models.UserModel user = new Models.UserModel();
            user.User = texboxUser.Text;
            user.Name = texboxName.Text;
            user.Phone = texboxPhone.Text;
            user.Charge = texboxCharge.Text;
            user.Email = texboxEmail.Text;
            user.Rol = comboBox.Text;

           
            if (isEdit)
            {
                Database.DatabaseController.updateUser(user,userMain.User,userMain.Name,userMain.Email);
            }
            else
                Database.DatabaseController.addUser(user);

            foreach (Window w in Application.Current.Windows) 
            {
                w.Hide();
            }            
            WelcomeProfile welcomeProfile = new WelcomeProfile();
            welcomeProfile.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /* Models.UserModel user = new Models.UserModel();
             user.User = texboxUser.Text;
             user.Name = texboxName.Text;
             user.Phone = texboxPhone.Text;
             user.Charge = texboxCharge.Text;
             user.Email = texboxEmail.Text;
             user.Rol = comboBox.Text;
             Database.DatabaseController.addUser(user);*/

            texboxUser.Text = "";
            texboxName.Text = "";
            texboxPhone.Text = "";
            texboxCharge.Text = "";
            texboxEmail.Text = "";
            comboBox.Text = "";
        }
    }
}
