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
using WpfBookShop.DAL.Modal;

namespace WpfBookShop.Pages.Home
{
    /// <summary>
    /// Interaction logic for LeftMenu.xaml
    /// </summary>
    public partial class LeftMenu : Page
    {
        Book db = new Book();
        public LeftMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.user != null && SineInButton.Content == "Sine Out")
            {
                MainWindow.user = null;
                SineInButton.Content = "Sine In";

                MainWindow.uMenu.Visibility = Visibility.Hidden;

                MainWindow.cf.Source = new Uri(@"Pages\Home\HomeCentralPage.xaml",
                                   UriKind.RelativeOrAbsolute);
            }
            else
            {
                string login = tbxUserName.Text;
                string password = tbxPassword.Password;

                MainWindow.user = db.TableUsers.FirstOrDefault(a => a.Login == login && a.Password == password);

                if (MainWindow.user != null && MainWindow.user.UserId == 1)
                {
                    MainWindow.uMenu.Visibility = Visibility.Visible;
                    SineInButton.Content = "Sine Out";
                }
                else if (MainWindow.user != null)
                {
                    MainWindow.cf.Source = new Uri(@"Pages\Home\HomeCentralPage.xaml",
                                 UriKind.RelativeOrAbsolute);
                }
                else
                {
                    MainWindow.cf.Source =
                                     new Uri(@"Pages\Users\AccessDenied.xaml",
                                     UriKind.RelativeOrAbsolute);
                }
            }
        }
    }
}
