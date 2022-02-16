using System;

namespace Numero1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe um valor:");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int z = 0; z < y; z++)
            {
                for (int f = 0; f < x; f++) Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
