using System;

namespace Exercicio08.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo oleo = new LataDeOleo();

            oleo.raio = 7;
            oleo.altura = 1;

            Console.WriteLine("O volume da lata de óleo e {0}",
                oleo.Obtem_Volume());
        }
    }
}
