using System;
using System.Globalization;

namespace URI_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double raio, volume, pi;
            pi = 3.14159;
      
       
            raio = double.Parse(Console.ReadLine());
       
            volume = (4.0/3.0) * pi * (Math.Pow(raio, 3.0));

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CI));
        }
    }
}