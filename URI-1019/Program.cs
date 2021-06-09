using System;

namespace URI_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos, minutos, horas, N, resto;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;
            
            Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);
        }
    }
}
