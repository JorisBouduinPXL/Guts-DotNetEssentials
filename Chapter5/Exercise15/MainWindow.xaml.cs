﻿using System;
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

namespace Exercise15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            
            // TODO: read input from secondsTextBox

            // TODO: convert with one method

            // TODO: show output in messagebox
        }

        private void convertButton_Click_1(object sender, RoutedEventArgs e)
        {
            int seconden = Convert.ToInt32(secondsTextBox.Text);
            int u, m, s;
            ConvertSecondsToHoursMinutesSeconds(seconden, out u, out m, out s);
            MessageBox.Show(String.Format("U: {0} M: {1} S: {2}", u, m, s));
        }

        private void ConvertSecondsToHoursMinutesSeconds(int seconden, out int u,  out int m, out int s)
        {
            u = seconden / 3600;
            seconden = seconden % 3600;
            m = seconden / 60;
            s = seconden % 60;

        }
    }
}
