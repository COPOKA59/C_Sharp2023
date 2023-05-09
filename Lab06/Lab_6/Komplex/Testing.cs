using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Класс для взаимодействия с пользователем

namespace Komplex
{
    public static class Testing
    {
        public static void Test()
        {
            Console.Write("  Введите два комплексных числа вида (a + bi)\n" +
                          "      вводится числа a и b через пробел\n");

            Console.Write("\n  Первое комплексное число: \n  ");
            string[] str = Console.ReadLine().Split(' ');
            Nomber.Nomber A = new Nomber.Nomber(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));

            Console.Write("  Второе комплексное число: \n  ");
            str = Console.ReadLine().Split(' ');
            Nomber.Nomber B = new Nomber.Nomber(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));

            Console.Write("\n  Результат сложения двух комплексных чисел\n  ");
            Nomber.Nomber C = Calculator.Calculator.Addition (A, B);
            C.Show();

            Console.Write("\n  Результат умножения двух комплексных чисел\n  ");
            C = Calculator.Calculator.Multiplication (A, B);
            C.Show();

            Console.Write("\n Результат вычисления модуля комплексных чисел\n  ");
            double D1 = Calculator.Calculator.Module(A);
            Console.WriteLine("    Модуль первого комп.числа = {0}", Math.Round(D1, 2));
            double D2 = Calculator.Calculator.Module(B);
            Console.WriteLine("      Модуль второго комп.числа = {0}", Math.Round(D2, 2));
        }
    }
}
