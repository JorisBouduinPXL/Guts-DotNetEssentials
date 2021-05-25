using System;
using System.Windows;

namespace Exercise14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private String ConvertNumberToBinary(int number)
        {

            String result = String.Empty;
            int division;


            division = number / 128;
            number = number % 128;
            result = result + division;

            division = number / 64;
            number = number % 64;
            result = result + division;

            division = number / 32;
            number = number % 32;
            result = result + division;

            division = number / 16;
            number = number % 16;
            result = result + division;

            division = number / 8;
            number = number % 8;
            result = result + division;

            division = number / 4;
            number = number % 4;
            result = result + division;

            division = number / 2;
            number = number % 2;
            result = result + division + number;

            return result;
        }

        private void convert_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(numberTextBox.Text);
            binTextBlock.Text = ConvertNumberToBinary(amount);
        }
    }
}
