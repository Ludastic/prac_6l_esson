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

namespace prac1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int true_pass = 9999;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Input.Text += Convert.ToInt32((sender as Button).Content);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Input.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(Input.Text) == true_pass)
            {
                Input.Text = "Correct!";
                Main_grid.IsEnabled = false;
                
            }
            else
            {
                Input.Text = "";
            }
        }
    }
}
