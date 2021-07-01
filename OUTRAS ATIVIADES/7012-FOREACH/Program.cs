using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] nomes;
            N = int.Parse(Console.ReadLine());
            nomes = new string[N];

            for (int i = 0; i < N; i++)
            {
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
