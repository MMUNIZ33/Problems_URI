using System;
using System.Globalization;

namespace _7002_SPLIT
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1, name2;
            int idade1, idade2;
            string[] vet;
            double media;
            CultureInfo CI = CultureInfo.InvariantCulture;

            vet = Console.ReadLine().Split(" ");
            name1 = vet[0];
            idade1 = int.Parse(vet[1]);
            vet = Console.ReadLine().Split(" ");
            name2 = vet[0];
            idade2 = int.Parse(vet[1]);

            media = (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de {0} e {1} é de {2} anos.", name1, name2, media.ToString("F1", CI));
        }
    }
}
