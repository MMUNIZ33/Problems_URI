using System;

namespace URI_1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, soma, cont;
            cont = 1;
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                soma = N * cont;
                Console.WriteLine("{0} x {1} = {2}", cont, N, soma);
                cont++;
            }
        }
    }
}
