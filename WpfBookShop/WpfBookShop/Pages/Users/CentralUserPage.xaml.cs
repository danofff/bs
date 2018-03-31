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

namespace WpfBookShop.Pages.Users
{
    /// <summary>
    /// Interaction logic for CentralUserPage.xaml
    /// </summary>
    public partial class CentralUserPage : Page
    {
        public CentralUserPage()
        {
            InitializeComponent();

            if(MainWindow.user!=null)
                HelloToUser.Content = MainWindow.user.lName+" "+MainWindow.user.fName;

        }

        
    }
}
