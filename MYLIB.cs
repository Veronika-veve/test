using System;

namespace MyLIB
{
    public static class ClassLib
    {
        public static void ArraySort(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                int[] row = new int[m];
                for (int j = 0; j < m; j++)
                {
                    row[j] = matrix[i, j];
                }

                Array.Sort(row);

                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
        }
        public static void Matrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }

        public static void ZapolnenyMmatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }

        }
    }
}
