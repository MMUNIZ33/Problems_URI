using System;

namespace _7015_SOMAMTZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int L, C;
            int[,] mtz;
            string[] y;

            // Gerar quantidade de linhas e colunas de mtz
            string[] x = Console.ReadLine().Split(' ');
            L = int.Parse(x[0]);
            C = int.Parse(x[1]);
            mtz = new int[L, C];

            // Atribuir valores de mtz
            for (int i = 0; i < L; i++)
            {
                y = Console.ReadLine().Split(' ');
                for (int j = 0; j < C; j++)
                {
                    mtz[i, j] = int.Parse(y[j]);
                }
            }

            // Atribuir valores de soma e imprimir soma das linhas de mtz
            int[] soma = new int[L];

            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    soma[i] = soma[i] + mtz[i, j];
                }
                Console.WriteLine(soma[i]);
            }
        }
    }
}
