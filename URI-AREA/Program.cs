using System;
using System.Globalization;

namespace URI_AREA
{
    class Program
    {
        static void Main(string[] args)
        {
            double bas, alt, area, perimetro, diagonal;
            CultureInfo CI = CultureInfo.InvariantCulture;
             
            bas = double.Parse(Console.ReadLine(), CI);
            alt = double.Parse(Console.ReadLine(), CI);

            area = bas * alt;
            perimetro = 2 * (bas + alt);
            diagonal = Math.Sqrt(Math.Pow(bas, 2) + Math.Pow(area, 2));
            
            Console.WriteLine("AREA = " + area.ToString("F4", CI));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CI));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));
        }
    }
}
