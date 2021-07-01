using System;
using System.Globalization;

namespace _7010_CALMEDIA
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N;
            double[] vet;
            var soma = 0.0;
            var media = 0.0;
            N = int.Parse(Console.ReadLine()); // ler quantidade de vetores de N
            vet = new double[N];

            string[] va = (Console.ReadLine().Split(' '));

            for (int i = 0; i < N; i++) // declarar vetores de N
            {
                vet[i] = double.Parse(va[i], CI);
            }
            for (int i = 0; i < N; i++) // imprimir vetores de N
            {
                Console.Write(vet[i].ToString("F1", CI) + " ");
            }
            for (int i = 0; i < N; i++) //somar valores de N
            {
                soma = soma + vet[i];
            }
            
            Console.WriteLine("\nSOMA = " + soma.ToString("F2", CI));
            media = soma / N;
            Console.WriteLine("MEDIA = " + media);

        }
    }
}
