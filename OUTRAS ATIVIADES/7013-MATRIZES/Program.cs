using System;

namespace _7013_MATRIZES
{
    class Program
    {
        static void Main(string[] args)
        {
            int C, L;
            int[,] A;
            string[] s;

            string[] va = Console.ReadLine().Split(' ');
            L = int.Parse(va[0]);
            C = int.Parse(va[1]);

            A = new int[L, C];

            // Atribuir valores de C e L
            for (int i = 0; i < L; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++)
                {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            // Imprimir
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}