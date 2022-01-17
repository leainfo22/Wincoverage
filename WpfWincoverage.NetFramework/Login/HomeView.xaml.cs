using System.Windows;
using System.Windows.Controls;

namespace WpfWincoverage.NetFramework.Login
{
    /// <summary>
    /// Lógica de interacción para HomeView.xaml
    /// </summary>
    public partial class HomeView : Page
    {
        public HomeView()
        {
            //var t = Database.DatabaseController.getUserList2();
            InitializeComponent();
            /*if (MainWindow.globalLanguage == "spanish")
            {
                Style style = this.FindResource("labelWelcomeSpanish") as Style;
                labelWelcome.Style = style;
            }*/
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //Main.Content = new Login.LoginView();
            //userBox.Visibility = Visibility.Visible;
            //passBox.Visibility = Visibility.Visible;

        }
    }
}
