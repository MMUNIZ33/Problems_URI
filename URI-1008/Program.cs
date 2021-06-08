using System;
using System.Globalization;

namespace URI_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            double numF, salary, horas, valorHora;
            CultureInfo CI = CultureInfo.InvariantCulture;

            numF = double.Parse(Console.ReadLine(), CI);
            valorHora = double.Parse(Console.ReadLine(), CI);
            horas = double.Parse(Console.ReadLine(), CI);

            salary = horas * valorHora;
            Console.WriteLine("NUMBER = " + numF);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CI));
        }
    }
}
