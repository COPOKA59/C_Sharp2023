/* Макарова Полина ПМИ-2
 * Вариант 10
 */

/*Вариант 10:
 * 1. R_x = a*b + b/t - x + f*i
 * 2. Z = (X^2 / 1*3) - (Y^4 / 3*5) + (X^6 / 5*7) - (Y^8 / 7*9) + ...
 */


Console.WriteLine("Индивидуальное задание 1");

// Объявление переменных
int a = 1, t = 3, x = 4, f = 5, i = 6;
double b = 2.3456, R_x;
// Вычисление R_x
R_x = a * b + b / t - x + f * i;
// Форматный вывод R_x
Console.WriteLine("\n Переменные:\n a = {0}, b = {1:F3}, t = {2}, x = {3}, f = {4}, i = {5} \n" +
    "\n Решение выражения(R_x = a * b + b / t - x + f * i):\n R_x = {6:F3}", a, b, t, x, f, i, R_x);


Console.WriteLine("\n Индивидуальное задание 2\n");

//Запись значений X, Y, N с клавиатуры
Console.WriteLine("Введите X:");
string str = Console.ReadLine();
double X = Convert.ToDouble(str);

Console.WriteLine("Введите Y:");
str = Console.ReadLine();
double Y = Convert.ToDouble(str);

Console.WriteLine("Введите количество слагаемых:");
str = Console.ReadLine();
int N = Convert.ToInt32(str);

//Нахожение суммы ряда
double Z = 0;
int k;
for (int j = 1; j < N+1; j++)
{
    k = j * 2;
    if (j % 2 != 0)
    {
        Z += Math.Pow(X, k) / ((k + 1) * (k - 1));
    }
    else
    {
        Z -= Math.Pow(Y, k) / ((k + 1) * (k - 1));
    }

}
// Форматированый вывод
Console.WriteLine("\n Переменные:\n X = {0:F3}, Y = {1:F3}\n " +
    "\n Значения ряда с количеством слогаемых N = {2}:\n Z = {3:F3}", X, Y, N, Z);

