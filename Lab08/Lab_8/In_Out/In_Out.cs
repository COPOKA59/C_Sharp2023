using System;
using System.IO;

namespace In_Out
{
    public class In_Out
    {
        int m, n;
        float[,] matrix;

        // Загрузка матрицы из файла
        public float[,] LoadMatrix(string pathFileName)
        {
            if (File.Exists(pathFileName))
            {
                try
                {
                    TextReader textReader = File.OpenText(pathFileName);
                    m = Convert.ToInt32(textReader.ReadLine());
                    n = Convert.ToInt32(textReader.ReadLine());

                    matrix = new float[m, n];
                    string line;
                    string[] substring;
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            line = textReader.ReadLine();
                            substring = line.Split(new char[] { ' ' }, 3);
                            matrix[i, j] = Convert.ToSingle(substring[2]);
                        }
                    }

                    textReader.Close();
                    return matrix;
                }
                catch
                {
                    return matrix;
                }
            }
            return matrix;
        }

        // Вывод матрицы в консоль
        public void PrintMatrix(int g)
        {
            if (matrix.Length > 0)
            {
                Console.WriteLine("Матрица " + g + ":\n");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j].ToString("E3") + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}