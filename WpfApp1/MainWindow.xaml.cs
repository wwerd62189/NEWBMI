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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            a1.Text = a.Value.ToString();

            double h = double.Parse(a1.Text);
            double w = double.Parse(b1.Text);
            double bmi = w / Math.Pow((h / 100), 2);

            bmi1.Text = "" + bmi.ToString("#0.0"); ;
        }

        private void b_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           b1.Text = b.Value.ToString();

            double h = double.Parse(a1.Text);
            double w = double.Parse(b1.Text);
            double bmi = w / Math.Pow((h / 100), 2);

            bmi1.Text = "" + bmi.ToString("#0.0"); ;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
