/* Макарова Полина ПМИ-2
 * Вариант 10
 * Лабораторная работа 4
 */

/* 1. Спроектируйте класс (ы), наполните его (их) требуемой функциональностью, 
 * продемонстрируйте работоспособность программы 
 * Класс "Цилиндр". 
 * Реализовать ввод и вывод полей данных, вычисление объёма, площади поверхности,
 * а так же вывод информации об объекте.
 * 
 * 2. Модифицируйте вашу программу таким образом, чтобы она использовала информацию, 
 * полученную в том числе и на лекциях. А именно (по возможности и целесообразности) 
 * продемонстрировать: инкапсуляцию; применение полей, свойств, конструкторов; 
 * включение, вложение, наследование классов; перегрузки методов/конструкторов; 
 * возможность задание параметров «по умолчанию» и с клавиатуры; 
 * задание параметров консоли и форматный вывод. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_4
{
    class Cylinder
    {
        // Поля данных: r - радиус, h - высота, pi - константа пи
        private double r, h;
        private const double pi = 3.141;

        // Конструктор по умолчанию
        public Cylinder()
        {
            r = 1;
            h = 1;
        }

        // Конструктор
        public Cylinder(double ra, double ha)
        {
            r = ra;
            h = ha;
        }

        // Метод для установки и считывания значений полей
        public double H
        {
            get { return this.h; }
            set { this.h = value; }
        }

        public double R
        {
            get { return this.r; }
            set { this.r = value; }
        }

        // Метод для вычисления объёма цилиндра
        private double GetV()
        {
            return pi * r * r * h;
        }

        // Метод для вычисления площади поверхности цилиндра
        private double GetS()
        {
            return 2 * pi * r * h + 2 * pi * r * r;
        }

        // Метод для вывода полной информации об объекте в консоль
        public void PrintFullInformation()
        {
            string str = "\n       --------------------------------\n" +
                           "       |                              |\n" +
                           "       |        Объект Цилиндр        |\n" +
                           "       |                              |\n" +
                           "       --------------------------------\n";
            Console.WriteLine(str);
            Console.WriteLine("   Данные Цилиндра:\n\n      Высота = {0:F3}\n      Радиус = {1:F3}\n", H, R);
            Console.WriteLine("\n   Объём Цилиндра = {0:F3}\n", GetV());
            Console.WriteLine("   Площадь поверхности Цилиндра = {0:F3}\n", GetS());
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Параметры консоли
            Console.Title = "Цилиндр";
            Console.SetWindowSize(60, 30);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            string a;
            double r, h;

            // Создание объекта Цилиндр
            Cylinder C;
            C = new Cylinder();
            Console.Write("            Введите 1 для ввода данных из консили\n" +
                          "    или любую цифру для задания параметров по умолчанию\n   ");
            a = Console.ReadLine();

            // Ввод данных из консоли
            if (Convert.ToDouble(a) == 1)
            {
                Console.Write("\n   Введите высоту Цилиндра = ");
                a = Console.ReadLine();
                C.H = (Convert.ToDouble(a));
                Console.Write("\n   Введите радиус Цилиндра = ");
                a = Console.ReadLine();
                C.R = (Convert.ToDouble(a));
            }

            // Вывод информации об объекте
            C.PrintFullInformation();

            Console.ReadKey();

        }
    }
}