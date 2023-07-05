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

namespace Task_9._5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show(
                    "Пустой текст",
                    this.Title,
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Information
                    );
            }
            else
            {
                listBox.ItemsSource = txtName.Text.Split(' ');
            }

        }

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show(
                    "Пустой текст",
                    this.Title,
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Information
                    );
            }
            else
            {
                List<string> newList = new List<string>();
                foreach (string s in txtName.Text.Split(' '))
                {
                    newList.Add(s);
                }

                newList.Reverse();

                string reverseText = "";

                foreach(string s in  newList)
                {
                    reverseText += s + "\n";
                }

                lblOut.Content = reverseText;

            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtName.Clear();
            listBox.ItemsSource= new List<string>();
            lblOut.Content = "";
        }
    }
}
