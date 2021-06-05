using System;
using System.Globalization;

namespace URI_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, media;
            CultureInfo CI = CultureInfo.InvariantCulture;

            A = double.Parse(Console.ReadLine(), CI);
            B = double.Parse(Console.ReadLine(), CI);

            media = (A * 3.5) + (B * 7.5);
            media = media / 11.0;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CI));
        }
    }
}
