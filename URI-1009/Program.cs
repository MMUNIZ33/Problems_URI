using System;
using System.Globalization;

namespace URI_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double salary, bonuss, vendass;
            double percentual = (15.0 / 100);
            CultureInfo CI = CultureInfo.InvariantCulture;

            name = Console.ReadLine();
            salary = double.Parse(Console.ReadLine(), CI);
            vendass = double.Parse(Console.ReadLine(), CI);

            bonuss = vendass * percentual + salary;

            Console.WriteLine("TOTAL = R$ " + bonuss.ToString("F2", CI));
        }
    }
}
