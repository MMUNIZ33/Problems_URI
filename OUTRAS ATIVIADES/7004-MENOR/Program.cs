using System;

namespace _7004_MENOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                System.Console.WriteLine("MENOR = " + x);       
            }
            else if (y < z)
            {
                System.Console.WriteLine("MENOR = " + y);
            }
            else
            {
                System.Console.WriteLine("MENOR = " + z);
            }
        }
    }
}
