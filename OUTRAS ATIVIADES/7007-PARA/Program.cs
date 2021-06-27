using System;

namespace _7007_PARA
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 0;
            var soma = 0;
            int N;
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }

            Console.WriteLine(soma);
        }
    }
}
