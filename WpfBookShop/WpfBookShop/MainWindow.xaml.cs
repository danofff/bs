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

namespace WpfBookShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Menu mMenu;
        public static MenuItem uMenu;


        public static Frame cf;
        public static TableUsers user;
        public MainWindow()
        {
            InitializeComponent();

            mMenu = MainMenu;
            uMenu = UsersMenu;

            LeftMenuFrame.Source = 
                new Uri(@"Pages\Home\LeftMenu.xaml", UriKind.RelativeOrAbsolute);

            CenterFrame.Source =
                new Uri(@"Pages\Home\HomeCentralPage.xaml", UriKind.RelativeOrAbsolute);

            cf = CenterFrame;
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.cf.Source = new Uri(@"Pages\Users\AddUser.xaml",
                                     UriKind.RelativeOrAbsolute);
        }

        private void TableUsers_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.cf.Source = new Uri(@"Pages\Users\ListUsers.xaml",
                                   UriKind.RelativeOrAbsolute);
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.cf.Source = new Uri(@"Pages\Books\AddBook.xaml",
                                   UriKind.RelativeOrAbsolute);
        }

        private void TableBooks_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.cf.Source = new Uri(@"Pages\Books\ListBooks.xaml",
                                   UriKind.RelativeOrAbsolute);
        }
    }
}
