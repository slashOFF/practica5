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

namespace prac5z1
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
                int num = Convert.ToInt32(ListBoxData.Items[0]);
                int sum = 0;
                int count = 0;
                for (int i = 1; ; i++)
                {

                    MessageBox.Show(num.ToString());
                    if (num == 0)
                    {
                        break;
                    }


                    if (num >= 10 && num <= 99)
                    {
                        sum += num;
                        count++;

                    }


                    num = Convert.ToInt32(ListBoxData.Items[i]);
                }
                if (count > 0)
                {
                    double avg = Convert.ToDouble(sum) / count;
                    TextBlockAnswer.Text = $"{avg:f2}";
                }
                else
                {
                    TextBlockAnswer.Text = "NO";
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
            if ((String.IsNullOrEmpty(TbNumber.Text)))
            {
                return;
            }
            try
            {
                int xa = Convert.ToInt32(TbNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxData.Items.Add(TbNumber.Text);
        }
    }
}