using System;
using System.Globalization;

namespace URI_1036
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double a, b, c, delta, r1, r2;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CI);
            b = double.Parse(vet[1], CI);
            c = double.Parse(vet[2], CI);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0 || delta < 0.0)
            {
                System.Console.WriteLine("Impossivel calcular");
            }          
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                System.Console.WriteLine("R1 = " + r1.ToString("F5", CI));
                System.Console.WriteLine("R2 = " + r2.ToString("F5", CI));
            }  
        }
    }
}
