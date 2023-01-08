using System;

namespace lab4ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Ex 3 dificultate ridicata
        Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n
        m, respectiv m,n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la
        tastaura. 
            Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I
        rezultatul.
             */
            Console.WriteLine("Introduceti n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti m:");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[n, m];
            int[,] matrix2 = new int[m, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Introduceti valori pentru matricea 1: [{i},{j}]:");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Introduceti valori pentru matricea 2: [{i},{j}]:");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            int a = GetResultOfMultiplication(matrix1, matrix2).GetLength(0);
            int b = GetResultOfMultiplication(matrix1, matrix2).GetLength(1);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(GetResultOfMultiplication(matrix1, matrix2)[i, j] + " ");
                }
                Console.WriteLine();
            }
            GetResultOfMultiplication(matrix1, matrix2);

        }

        static int[,] GetResultOfMultiplication(int[,] matrix1, int[,] matrix2)
        {
            int n = matrix1.GetLength(0);
            int m = matrix1.GetLength(1);

            int mm = matrix2.GetLength(1);

            int[,] result = new int[n, mm];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < mm; j++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }
    }
}
