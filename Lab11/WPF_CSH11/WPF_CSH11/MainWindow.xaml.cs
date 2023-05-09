/* Макарова Полина ПМИ-2
 * Вариант 10
 * Лабораторная работа 11
 */

using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPF_CSH11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ((Button)RootLayout.FindName("confirmButton")).Click += ConfirmButton_Click;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            double x1, x2, x3, x4, x5, results;
            //Проверка на правильность введённыхх данных
            try
            {
                //Присвоение соответствующим переменным введённых данных
                x1 = Convert.ToDouble(((TextBox)RootLayout.FindName("TextBox1")).Text);
                x2 = Convert.ToDouble(((TextBox)RootLayout.FindName("TextBox2")).Text);
                x3 = Convert.ToDouble(((TextBox)RootLayout.FindName("TextBox3")).Text);
                x4 = Convert.ToDouble(((TextBox)RootLayout.FindName("TextBox4")).Text);
                x5 = Convert.ToDouble(((TextBox)RootLayout.FindName("TextBox5")).Text);

                results = Math.Round((x1 - x2 + Math.Abs(Math.Cos(x3) + Math.Sqrt(Math.Abs(x4)))) / (Math.Pow(x1, x5) - Math.Log(x2)), 3);
                // Проверяем вторую кнопку на вывод
                if (RadioButton2.IsChecked == true)
                {
                    // Проверка на вывод
                    if (CheckBox1.IsChecked == true)
                    {
                        // Вывод на листбокс
                        ListBox1.Items.Add(string.Format("arg01 = " + x1 +
                            "  | arg02 = " + x2 +
                            "  | arg03 = " + x3 +
                            "  | arg04 = " + x4 +
                            "  | arg05 = " + x5 +
                            "  |  Результат = " + results.ToString()));
                    }
                    if (CheckBox2.IsChecked == true)
                    {
                        // Вывод в файл
                        string str = "arg01 = " + x1 +
                            "  | arg02 = " + x2 +
                            "  | arg03 = " + x3 +
                            "  | arg04 = " + x4 +
                            "  | arg05 = " + x5 +
                            "  |  Результат = " + results.ToString() + Environment.NewLine;

                        StreamWriter SW = new StreamWriter(((TextBox)RootLayout.FindName("TextBox7")).Text, true); // Открываем файл на дозапись
                        SW.Write(string.Format(str)); //Записываем строку
                        SW.Close(); //Закрываем файл
                    }
                }
            }
            catch (FormatException)
            {
                ListBox1.Items.Add("Неверно введены данные!");
            }
        }
    }
}
