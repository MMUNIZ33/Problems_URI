using System;

namespace _7014_MTZQUA
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, cont;
            cont = 0;
            int[,] mtz;
            string[] x;

            // Leitura de N
            N = int.Parse(Console.ReadLine());
            mtz = new int[N, N];

            // Atribuir valores de mtz
            for (int i = 0; i < N; i++)
            {
                x = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mtz[i, j] = int.Parse(x[j]);
                }
            }

            // Imprimir diagonal de mtz
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mtz[i, i] + " ");
            }

            // Imprimir números negativos de mtz
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mtz[i, j] < 0)
                    {
                        cont++;
                        // Console.Write(mtz[i, j] + " ");
                    }
                }
            }
            Console.WriteLine("\nQUANTIDADE DE NEGATIVOS: " + cont);
        }
    }
}
