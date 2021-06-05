using System;
using System.Globalization;

namespace URI_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, media;
            CultureInfo CI = CultureInfo.InvariantCulture;

            A = double.Parse(Console.ReadLine(), CI);
            B = double.Parse(Console.ReadLine(), CI);
            C = double.Parse(Console.ReadLine(), CI);

            media = ((A*2) + (B*3) + (C*5)) / 10;  
            Console.WriteLine("MEDIA = " + media.ToString("F1", CI));
        }
    }
}
