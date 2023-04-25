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

namespace prac5z3
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
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(TbNumberA.Text);
                double n = int.Parse(TbNumberB.Text);
                double sum = 1;
                int sign = 1;
                for (int i = 1; i <= n; i++)
                {
                    sign *= -1;
                    int fact = 1;
                    for (int j = 1; j <= 2 * i; j++)
                    {
                        fact *= j;
                    }
                    double term = sign * Math.Pow(x, 2 * i) / fact;
                    sum += term;
                    TextBlockAnswer.Text = $"{sum}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumberA.Text)))
            {
                return;
            }
            try
            {
                double xa = Convert.ToDouble(TbNumberA.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxData.Items.Add(TbNumberA.Text);
            ListBoxData.Items.Add(TbNumberB.Text);
        }
    }
}