using System;
using System.Globalization;

namespace URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int num1, num2, cod1, cod2;
            double preco1, preco2, valor;
            
            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            num1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CI);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            num2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CI);

            valor = (num1 * preco1) + (num2 * preco2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2", CI));
        }
    }
}