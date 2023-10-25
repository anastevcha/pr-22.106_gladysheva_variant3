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

namespace pr_22._106_gladysheva_variant3
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
            try
            {
                int n = int.Parse(txtBoxDiaposon.Text);
                int minRange = int.Parse(minRangeTextBox.Text);
                int maxRange = int.Parse(MaxRangeTextBox.Text);

                if (n < minRange || n > maxRange)
                {
                  
                }
                else
                {
                    int[] array = GenerateArray(n, minRange, maxRange);
                    SortArray(array);
                    ArrayTextBox.Text = string.Join(", ", array);
                }
            }
            catch (FormatException)
            {
                ArrayTextBox.Text = ("Недопустимый формат");
            }
            catch (OverflowException)
            {
                ArrayTextBox.Text = ("Недопустимый формат");
            }

        }
        private static int[] GenerateArray(int n, int minRange, int maxRange)
        {
            Random random = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(minRange, maxRange + 1);
            }

            return array;
        }

        private static void SortArray(int[] array)
        {
            Array.Sort(array, (x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                    return -1;
                else if (x % 2 != 0 && y % 2 == 0)
                    return 1;
                else
                    return 0;
            });
        }

    }
    
}





