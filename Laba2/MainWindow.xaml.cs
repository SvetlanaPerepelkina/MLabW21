using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.ComponentModel;

namespace Laba2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingListCollectionView<string> results;
        Values values;
        double summ;
        double sum;
        int start;
        int stop;
        int step;
        int n;
        int k;
        int x;
        double y;

        public MainWindow()
        {
            InitializeComponent();
            values = new Values();
            results = new BindingListCollectionView<string>();
            ListBox1.DataContext = results;
            Values values2 = new Values();
            this.DataContext = values2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            start = Convert.ToInt32(Start.Text);
            stop = Convert.ToInt32(Stop.Text);
            step = Convert.ToInt32(Step.Text);
            n = Convert.ToInt32(N.Text);

            double S = Math.Sin(Math.PI / 4);
            double C = Math.Cos(Math.PI / 4);
            sum = 0;

                try {

                    for (int j = start; j <= stop; j = j + step) 
                    {
                        start = start + step;
                        y = Math.Round((start * S) / (1 - (2 * start * C) + Math.Pow(start, 2)), 3);

                        for (int i = 1; i <= n; i++)
                        {
                            summ = Math.Pow(start, i) * Math.Pow(S, i);
                            sum = sum + summ;
                        }

                        ListBox1.DataContext = results;
                        results.Add("S = " + Math.Round(sum, 3).ToString() + "\t Y = " + y.ToString());
                    }
                }
                 catch { new Exception(); }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Start.Text = string.Empty;
            Stop.Text = string.Empty;   
            Step.Text = string.Empty;
            N.Text = string.Empty;
            ListBox1.ItemsSource = string.Empty;
        }
    }
}

