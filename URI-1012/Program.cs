using System;
using System.Globalization;

namespace URI_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangulo, quadrado, circulo, trapezio, retangulo;
            double pi = 3.14159;
            CultureInfo CI = CultureInfo.InvariantCulture;
       
            string[] vet = Console.ReadLine().Split(' ');
       
            a = double.Parse(vet[0], CI);
            b = double.Parse(vet[1], CI);
            c = double.Parse(vet[2], CI);
       
            
            triangulo = (a * c) / 2.0;
            circulo = (Math.Pow(c, 2.0)) * pi;
            trapezio = ((a + b ) * c) / 2;
            quadrado = b * b;
            retangulo = a * b;
            
            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CI));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CI));   
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CI));   
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CI));   
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CI));   
        }
    }
}
