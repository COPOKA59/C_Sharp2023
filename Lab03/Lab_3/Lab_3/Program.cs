
/* Макарова Полина ПМИ-2
 * Вариант 10
 * Лабораторная работа 3
 */

/* 1. Напишите алгоритм накопления суммы элементов одномерного массива, 
 * а затем создайте по нему программу. Элементы вводите с клавиатуры. 
 * Размер массива 10. Вывод результатов форматный.  
 * 
 * 2. Напишите алгоритм поиска максимального элемента двумерного 
 * массива (10, 12). Элементы массива генерируется с помощью класса Random. 
 * Для вывода элементов сгенерированного массива использовать цикл foreach. 
 * Создайте по нему программу. Статья как задать случайные 
 * числа http://plssite.ru/csharp/csharp_random_article.html 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

Console.SetWindowSize(63, 40); 
Console.BackgroundColor = ConsoleColor.White; 
Console.Clear(); 
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine("  |  Индивидуальное задание 1  |\n");

// Объявление переменных
double S = 0;
// Объявление массива A
double[] A = new double[10];
// Ввод элементов массива X(10)
Console.WriteLine("\nВведите элементы массива A");

for (int i = 0; i < 10; i++)
{
    A[i] = double.Parse(Console.ReadLine());
}
// Накопление суммы элементов массива
for (int i = 0; i < 10; i++)
{
    S += A[i];
}
// Вывод суммы эл.массива
Console.WriteLine("\n Сумма элементов массива A равна: {0}", S);


Console.WriteLine("\n\n  |  Индивидуальное задание 2  |\n\n");
// Создание двумерного массива
double[,] B = new double[10, 12];
// Создание объекта для генерации чисел
Random rnd = new Random();
Console.WriteLine("\nЭлементы массива B");
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 12; j++)
    {
    // Получить случайное число
    B[i, j] = rnd.Next(-100, 100);
    }
}

int N = 0, M = 0;
double max = B[0, 0];
// Поиск максимального элемента массива
// Вывод в консоль массива
foreach (int i in Enumerable.Range(0, B.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, B.GetLength(1)))
    {
        Console.Write("{0,5}", B[i, j]);
        // Поиск максимального элемента массива
        if (B[i, j] > max)
        {
            max = B[i, j];
            N = i;
            M = j;
        }

    }
    Console.WriteLine();
}

// Вывод в консоль мак.эл.массива
Console.WriteLine("\nМаксимальный элемент массива: {0}", max);
Console.WriteLine("\nЭллемент массива [{0}, {1}]", N+1, M+1);

