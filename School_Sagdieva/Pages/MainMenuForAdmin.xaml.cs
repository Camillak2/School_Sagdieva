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

namespace School_Sagdieva.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenuForAdmin.xaml
    /// </summary>
    public partial class MainMenuForAdmin : Page
    {
        public MainMenuForAdmin()
        {
            InitializeComponent();
        }

        private void ServicesBTN_Click(object sender, RoutedEventArgs e)
        {
            NaFr.NavigationService.Navigate(new ServicesPage());
        }

        private void ClientsBTN_Click(object sender, RoutedEventArgs e)
        {
            NaFr.NavigationService.Navigate(new ClientsPage());
        }

        private void RecordsBTN_Click(object sender, RoutedEventArgs e)
        {
            NaFr.NavigationService.Navigate(new RecordsPage());
        }

        private void ExitBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
