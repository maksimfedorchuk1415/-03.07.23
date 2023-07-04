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

namespace _11
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

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            string input = kolichestvo.Text; // получаем значение из textBox
            int length = int.Parse(input); // конвертируем значение в int
            int[] numbers = new int[length]; // создаем массив
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            { // заполняем элементы массива случайными числами
                numbers[i] = rand.Next(-100, 150 + 1);
            }
            massiv.Text = string.Join(", ", numbers); // выводим заполненный массив на textBox2
            double[] arr = massiv.Text.Split(' ').Select(x => double.Parse(x)).ToArray();
            double b = Convert.ToDouble(number.Text);
            double message = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % b == 0 && arr[i] < 100)
                {
                    message += arr[i];
                }
            }
            MessageBox.Show("Сумма чисел кратных " + b + " и меньше 100 это: " + message);
        }
    }
}
