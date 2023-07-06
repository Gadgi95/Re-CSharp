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

namespace Task_10._8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //Clients Ivanov1 = new Clients("Иванов1", "Иван", "Иванович", 89991111111, "8811 123456");
            //Clients.clientsList.Add(Ivanov1);
            //Clients Ivanov2 = new Clients("Иванов2", "Иван", "Иванович", 89992222222, "8822 123456");
            //Clients.clientsList.Add(Ivanov2);
            //Clients Ivanov3 = new Clients("Иванов3", "Иван", "Иванович", 89993333333, "8833 123456");
            //Clients.clientsList.Add(Ivanov3);
            //Clients Ivanov4 = new Clients("Иванов4", "Иван", "Иванович", 89994444444, "8844 123456");
            //Clients.clientsList.Add(Ivanov4);
            //Clients Ivanov5 = new Clients("Иванов5", "Иван", "Иванович", 89995555555, "8855 123456");
            //Clients.clientsList.Add(Ivanov5);
            //Clients Ivanov6 = new Clients("Иванов6", "Иван", "Иванович", 89996666666, "8866 123456");
            //Clients.clientsList.Add(Ivanov6);

        }

        private void ListOfClients_Initialized(object sender, EventArgs e)
        {
            ListOfClients.ItemsSource = Clients.GetClientsList();
        }

        private void ListOfClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClientInfoTextBlock.Text = ListOfClients.SelectedItem.ToString();
        }

    }
}
