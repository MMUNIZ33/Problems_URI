using System;
using System.Globalization;

namespace _7011_ALTMEDIA
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double mediaAlt = 0.0;
            var porcentagem = 0.0;
            int N, cont;
            cont = 0;
            string[] info;
            string[] nomes;
            int[] idades;
            double[] alturas;

            // Leitura de Dados
            N = int.Parse(Console.ReadLine());
            nomes = new string[N];
            idades = new int[N];
            alturas = new double[N];

            // Atribuir os valores dos vetores
            for (int i = 0; i < N; i++)
            {
                info = Console.ReadLine().Split(' ');
                nomes[i] = info[0];
                idades[i] = int.Parse(info[1], CI);
                alturas[i] = double.Parse(info[2], CI);
            }

            // Calcular média das alturas
            for (int i = 0; i < N; i++)
            {
                mediaAlt = mediaAlt + alturas[i];
            }
            mediaAlt = mediaAlt / N;

            // Contar idades abaixo de 16
            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
            }

            porcentagem = (double) cont / N * 100;

            // Imprimir
            Console.WriteLine("Altura média: " + mediaAlt.ToString("F2", CI));
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CI) + "%");
        }
    }
}
