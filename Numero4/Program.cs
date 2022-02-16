using System;

namespace Numero4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe um valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe um valor:");
            int valor3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe um valor:");
            int valor4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe um valor:");
            int valor5 = Convert.ToInt32(Console.ReadLine());
            int contadorPositivo = 0;
            int media = (valor1 + valor2 + valor3 + valor4 + valor5) / 5;
            if (valor1 > 0) contadorPositivo++;
            if (valor2 > 0) contadorPositivo++;
            if (valor3 > 0) contadorPositivo++;
            if (valor4 > 0) contadorPositivo++;
            if (valor5 > 0) contadorPositivo++;

            Console.WriteLine($"Média: {media}\nPositivos {contadorPositivo}\nNegativos {5 - contadorPositivo}");
        }
    }
}
