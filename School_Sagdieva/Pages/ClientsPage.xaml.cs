using School_Sagdieva.DB;
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
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        public static List<Client> clients { get; set; }

        public ClientsPage()
        {
            InitializeComponent();
            clients = DBConnection.se.Client.ToList();
            ClientsLV.ItemsSource = clients;
        }

        private void ClientsLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EditBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
