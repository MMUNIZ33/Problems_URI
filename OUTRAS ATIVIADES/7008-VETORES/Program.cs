using System;
using System.Globalization;

namespace _7008_VETORES
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double[] vet;
            int x;

            x = int.Parse(Console.ReadLine());
            vet = new double[x];

            for (int i = 0; i < x; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(vet[i].ToString("F2", CI));
            }
        }
    }
}
