using System;
using System.Globalization;

namespace _7006_ENQUANTO
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int cont;
            double idade, media;
            media = 0.0;
            cont = 0;
            idade = 0.0;
           
            idade = double.Parse(Console.ReadLine(), CI);

            while (idade >= 0)
            {
                media = media + idade;
                cont++;
                idade = double.Parse(Console.ReadLine(), CI);
            }


            if (cont == 0)
            {
                System.Console.WriteLine("Impossível calcular");
            } 
            else
            {
                double result = media / cont;
                Console.WriteLine(result.ToString("F2", CI));
            }
        }
    }
}
