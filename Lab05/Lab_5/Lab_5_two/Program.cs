/* Макарова Полина ПМИ-2
 * Вариант 10
 * Лабораторная работа 5
 */

/* Используя инструменты и методы визуального проектирования, создайте классы 
 * с наследниками, содержащие указанные поля, конструкторы и методы. В классе 
 * Program создаются и инициализируются 2–3 объекта и указанными методами выводится 
 * информация. Продемонстрируйте результаты, изменяя параметры. 
 * 
 * Спроектируйте класс Transport с полями mоdel (модель), speed (скорость), mas (масса) 
 * и методами Start (вывод звука), Stop, ShowInfo. Наследуйте от него классы Avto (автомобиль), 
 * Moto (мотоцикл), Velo (велосипед). Переопределите метод Start для каждого транспорта 
 * (например, машина - …жжжжж.., мотоцикл - ..так-так-так.., велосипед - ..тишина..).
 */

using Lab_5_two;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.SetWindowSize(75, 30);
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        // Создание объекта автомобиль
        Avto Av = new Avto("Lada", 60, 500);
        Av.ShowInfo();
        Av.Start(); Av.Stop();

        // Создание объекта мотоцикл
        Moto Mo = new Moto("Восход", 75, 80);
        Mo.ShowInfo();
        Mo.Start(); Mo.Stop();

        // Создание объекта велосипед
        Velo Ve = new Velo("Кама", 5, 15);
        Ve.ShowInfo();
        Ve.Start(); Ve.Stop();

    }
}