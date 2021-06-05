using System;

namespace URI_1003
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());

            int SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}
