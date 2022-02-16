using System;

namespace Numero5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um Nome: ");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Informe um Nome: ");
            string nome2 = Console.ReadLine();
            int contadorRech = 0, contadorThiago = 0;
            int x = 0;


            for (int i = 0; i < 3; i++)
            {
                int rech = new Random().Next(1, 6);
                Console.WriteLine($"\n{nome1} 1 valor: {rech}");
                int thiago = new Random().Next(1, 6);
                Console.WriteLine($"{nome2} 2 valor: {thiago}");
                if (rech > thiago)
                {
                    contadorRech++;
                    Console.WriteLine($"{nome1} ganhou");
                }
                else if (rech < thiago)
                {
                    thiago++;
                    Console.WriteLine($"{nome2} ganhou");
                }
                else if(rech == thiago) Console.WriteLine("Empate");
            }



            if (contadorRech > contadorThiago) Console.WriteLine($"\n\n{nome1} ganhou o jogo");
            else if (contadorRech < contadorThiago) Console.WriteLine($"\n\n{nome2} ganhou o jogo");
            else Console.WriteLine("\n\nEMPATE DO JOGO");
        }
    }
}
