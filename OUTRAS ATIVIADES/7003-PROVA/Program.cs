using System;
using System.Globalization;

namespace _7003_PROVA
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, total;
            CultureInfo CI = CultureInfo.InvariantCulture;
            nota1 = double.Parse(Console.ReadLine(), CI);
            nota2 = double.Parse(Console.ReadLine(), CI);

            total = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + total.ToString("F1", CI));
            
            if (total < 70)
            {
                System.Console.WriteLine("REPROVADO!");
            }
            else
            {
                System.Console.WriteLine("APROVADO!");
            }

        }
    }
}
