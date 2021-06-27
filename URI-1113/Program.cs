using System;

namespace URI_1113
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] z = Console.ReadLine().Split(' ');
            x = int.Parse(z[0]);
            y = int.Parse(z[1]);

            while (x != y)
            {
                if (y < x)
                {
                    System.Console.WriteLine("Decrescente");
                }
                else (x < y)
                {
                    System.Console.WriteLine("Crescente");
                }

                z = Console.ReadLine().Split(' ');
                x = int.Parse(z[0]);
                y = int.Parse(z[1]);
            }
        }
    }
}
