using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int inputNumOne = 0;
        int inputNumTwo = 0;
        char inputChar = ' ';
        int inputCharIndex = 0;
        int result = 0;
        string outPut = " ";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "1";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "2";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "3";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "4";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "5";
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "6";
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "7";
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "8";
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "9";
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Text += "0";
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            TxtBox.Clear();
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxtBox.Text, out inputNumOne);
            inputChar = '/';
            TxtBox.Text += '/';
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxtBox.Text, out inputNumOne);
            inputChar = '*';
            TxtBox.Text += '*';
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxtBox.Text, out inputNumOne);
            inputChar = '-';
            TxtBox.Text += '-';
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TxtBox.Text, out inputNumOne);
            inputChar = '+';
            TxtBox.Text += '+';
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            string input = (string)TxtBox.Text;

            if (string.IsNullOrEmpty(input))
            {
                outPut = "error";
            }
            else
            {
                inputCharIndex = input.IndexOf(inputChar);

                var subStringNumOne = input.Substring(0, inputCharIndex);

                int.TryParse(subStringNumOne, out inputNumOne);

                var subStringNumTwo = input.Substring(inputCharIndex + 1);

                int.TryParse(subStringNumTwo, out inputNumTwo);

                switch (inputChar)
                {
                    case '*':
                        result = inputNumOne * inputNumTwo;
                        break;
                    case '/':
                        result = inputNumOne / inputNumTwo;
                        break;
                    case '-':
                        result = inputNumOne - inputNumTwo;
                        break;
                    case '+':
                        result = inputNumOne + inputNumTwo;
                        break;
                }
            }

            outPut = result.ToString();

            TxtBox.Text = outPut;
        }
    }
}
