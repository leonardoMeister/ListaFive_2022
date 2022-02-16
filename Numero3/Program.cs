using System;

namespace Numero3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a hora:");
            int hora = Convert.ToInt32(Console.ReadLine());

            if (hora < 12) Console.WriteLine("Bom Dia");
            else if (hora >12 && hora <=18) Console.WriteLine("Boa tarde");
            else if (hora >18) Console.WriteLine("Boa Noite");
            if (hora == 12) Console.WriteLine("Meio dia");
        }
    }
}
