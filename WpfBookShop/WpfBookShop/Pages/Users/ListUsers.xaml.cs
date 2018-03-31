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

namespace WpfBookShop.Pages.Users
{
    /// <summary>
    /// Interaction logic for ListUsers.xaml
    /// </summary>
    public partial class ListUsers : Page
    {
        Book db = new Book();

        public ListUsers()
        {
            InitializeComponent();
            UserList.ItemsSource = db.TableUsers.ToList();
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {

            if(UserList.SelectedItems.Count>1)
            {
                foreach (var item in  UserList.SelectedItems)
                {
                    try
                    {
                        db.TableUsers.Remove((TableUsers)item);
                        db.SaveChanges();
                    }
                    catch (Exception){}
                }
            }
            else
            {
                TableUsers user = (TableUsers)UserList.SelectedItem;
                try
                {
                    db.TableUsers.Remove(user);
                    db.SaveChanges();
                }
                catch (Exception){}
            }

            UserList.ItemsSource = db.TableUsers.ToList();
        }
    }
}
