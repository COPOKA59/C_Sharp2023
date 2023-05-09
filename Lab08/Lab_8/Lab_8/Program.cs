/* Макарова Полина ПМИ-2
 * Вариант 10
 * Лабораторная работа 8
 */

/* В каждом варианте необходимо спроектировать многомодульное приложение (минимум 2 модуля). 
 * Исходные данные в каждом варианте программа получает из входного файла. 
 * 
 * Программа рассчитывает сумму элементов чётных строк в двух матрицах, 
 *    которые хранятся в разных файлах.
 */

using System;

namespace Lab_8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            float S1, S2;
            float[,] m;

            // Расчитывание суммы и вывод на экран
            Summ_out.Summ_out s = new Summ_out.Summ_out();
            In_Out.In_Out m1 = new In_Out.In_Out();
            // Загружаем матрицу из файла
            m = m1.LoadMatrix("FileMatrix1.txt");
            // Выводим матрицу из файла
            m1.PrintMatrix(1);
            // Находим сумму элементов чётных строк матрицы
            S1 = s.Summ(m);

            m = m1.LoadMatrix("FileMatrix2.txt");
            m1.PrintMatrix(2);
            S2 = s.Summ(m);
            
            // Находим общую сумму элементов двух матриц
            s.Print_Summ(S1, S2);


            DirectoryInfo dir1 = new DirectoryInfo(@"C:\Users\User\source\repos\Lab_8\Lab_8\bin\Debug\net6.0");
            if (dir1.Exists)
            {
                Console.WriteLine("\nDirectoryInfo dir1:");
                Console.WriteLine("FullName: {0}", dir1.FullName);
                Console.WriteLine("Name: {0}", dir1.Name);
                Console.WriteLine("Parent: {0}", dir1.Parent);
                Console.WriteLine("CreationTime: {0}", dir1.CreationTime);
                Console.WriteLine("Attributes: {0}", dir1.Attributes);
                Console.WriteLine("Root: {0}", dir1.Root);
                Console.WriteLine();
            }
            // Создаём подкаталог
            dir1.CreateSubdirectory("In");
            // Создаём вложенный каталог
            dir1.CreateSubdirectory(@"Out\3");

            Console.ReadKey();
        }
    }
}