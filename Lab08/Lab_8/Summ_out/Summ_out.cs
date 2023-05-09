namespace Summ_out
{
    public class Summ_out
    {
        int m, n;
        float S;

        // Конструктор
        public Summ_out() 
        {
            m = 0;
            n = 0;
            S = 0;
        }

        // Рассчитывание суммы чётных строк матрицы
        public float Summ(float[,] matrix)
        {
            S = 0;
            // Узнаём размер матрицы
            m = matrix.GetLength(0); //Для [i]
            n = matrix.GetLength(1); // для [j]
            Console.WriteLine("Размер матрицы: " + m + " , " + n);
            // Перебираем эллементы матрицы
            if (matrix.Length > 0)
            {
                Console.WriteLine(" Чётные строки матрицы:\n");
                // Строки считаються с 1, а не с 0.
                // Т.е. 0 строка в матрице это 1 строка в представлении.
                // => т.к. 0 строка это 1, то она нечётна, значит начинаем считать со строки 1(2).
                for (int i = 1; i < m; i+=2)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j].ToString("E3") + " ");
                        S += matrix[i, j];
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                return S;
            }
            else
            {
                Console.WriteLine("Нет данных");
                return 0;
            }
        }

        // Сумма двух сумм от двух матриц и вывод на экран
        public void Print_Summ(float A, float B)
        {
            Console.WriteLine("Сумма элементов чётных строк матрицы 1: " + A);
            Console.WriteLine("Сумма элементов чётных строк матрицы 2: " + B);
            S = A + B; // Сумма
            Console.WriteLine("\nИтоговая сумма: " + S);
        }
    }
}