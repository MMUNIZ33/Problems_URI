using System;

namespace _7005_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, soma;
            soma = 0;
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                soma = soma + num;
                num = int.Parse(Console.ReadLine());
            }
            
            System.Console.WriteLine(soma);
        }
    }
}
