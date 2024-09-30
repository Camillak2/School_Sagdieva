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
using School_Sagdieva.Pages;
using School_Sagdieva.DB;

namespace School_Sagdieva.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public static List<Client> clients { get; set; }

        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string login = LoginTB.Text.Trim();
                clients = DBConnection.se.Client.ToList();
                var currentUser = clients.FirstOrDefault(x => x.Email.Trim() == login);
                DBConnection.loggedClient = currentUser;

                if (currentUser != null)
                {
                    NavigationService.Navigate(new MainMenuForClient());
                }
                if (currentUser == null && login == "0000")
                {
                    NavigationService.Navigate(new MainMenuForAdmin());
                }
                else
                {
                    MessageBox.Show("Неверный логин! Попробуйте снова.");
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка! Попробуйте снова.");
            }
        }
    }
}
