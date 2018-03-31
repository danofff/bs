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
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Page
    {
        Book db = new Book();
        public AddUser()
        {
            InitializeComponent();
            CityId.ItemsSource = db.TableCity.Select(s =>s.CityName).ToList();
        }

        private void ButtonAddUser_Click(object sender, RoutedEventArgs e)
        {
            TableUsers newUser = new TableUsers();
            newUser.lName = lName.Text;
            newUser.Login = Login.Text;
            newUser.Password = Password.Password;
            newUser.CityId = 0;

            var cityName = CityId.SelectedItem;
            TableCity city = db.TableCity.FirstOrDefault(f => f.CityName == cityName);
            if(city!=null)
                newUser.CityId = city.CityId;
            
            if (string.IsNullOrEmpty(newUser.lName) || string.IsNullOrEmpty(newUser.Login))
            {
                ErrMessage.Content = "Заполните обязательные поля";
                ErrMessage.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                try
                {
                    db.TableUsers.Add(newUser);
                    db.SaveChanges();
                    ErrMessage.Content = "Пользователь добавлен!";
                    ErrMessage.Foreground = new SolidColorBrush(Colors.Green);
                    ErrMessage.FontWeight = FontWeights.Bold;
                }
                catch (Exception ex)
                {
                    ErrMessage.Content = "Пользователь не добавлен: " + ex.Message;
                    ErrMessage.Foreground = new SolidColorBrush(Colors.Red);
                    ErrMessage.FontWeight = FontWeights.Bold;
                }
            }

           
           
            
        }
    }
}
