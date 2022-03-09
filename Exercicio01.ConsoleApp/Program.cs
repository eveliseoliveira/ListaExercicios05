using System;

namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixa = new CaixaRetangular();

            caixa.comprimento = 8;
            caixa.altura = 8;
            caixa.largura = 8;

            Console.WriteLine("O volume da caixa é {0}", 
                caixa.Obtem_Volume());
        }
    }
}
