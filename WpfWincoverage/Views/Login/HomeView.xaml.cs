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

namespace WpfWincoverage.Login
{
    /// <summary>
    /// Lógica de interacción para HomeView.xaml
    /// </summary>
    public partial class HomeView : Page
    {
        public HomeView()
        {
            var t = Database.DatabaseController.getUserList2();
            InitializeComponent();
            if (MainWindow.globalLanguage == "spanish")
            {
                Style style = this.FindResource("labelWelcomeSpanish") as Style;
                labelWelcome.Style = style;
            }/**/
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //Main.Content = new Login.LoginView();
            //userBox.Visibility = Visibility.Visible;
            //passBox.Visibility = Visibility.Visible;

        }
    }
}
