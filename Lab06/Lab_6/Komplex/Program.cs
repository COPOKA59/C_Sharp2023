
/* Макарова Полина ПМИ-2
 * Вариант 10
 * Лабораторная работа 6
 */


/* Спроектируйте многомодульное приложение (3 модуля), реализующее 
 * поставленную задачу. Перед выполнением приложения необходимо выполнить 
 * декомпозицию задачи и выявить основные объекты предметной области.
 * 
 * Вариант 10 >
 * Реализуйте программу для выполнения операций над комплексными числами:
 * сложение, умножение, вычисление модуля комп.числа. Исходные комп.числа
 * пользователь вводит с клавиатуры.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 35);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Testing.Test();
        }

    }
}