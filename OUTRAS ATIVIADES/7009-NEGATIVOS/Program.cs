using System;

namespace _7009_NEGATIVOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] vet;
            N = int.Parse(Console.ReadLine()); // ler quantidade de vetores de N
            vet = new int[N];

            string[] va = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) // declarar vetores de N
            {
                vet[i] = int.Parse(va[i]);
            }
            for (int i = 0; i < N; i++) // imprimir vetores de N negativos
            {
                if (vet[i] < 0)
                {
                    System.Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
