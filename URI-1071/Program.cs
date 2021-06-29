using System;

namespace URI_1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max, soma;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }

            soma = 0;

            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma =  soma + i;
                }
            }

            System.Console.WriteLine(soma);
        }
    }
}
