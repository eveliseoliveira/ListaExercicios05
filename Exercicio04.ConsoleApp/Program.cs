using System;

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumoCombustivel consumo = new ConsumoCombustivel();

            consumo.km_inicial = 2000;
            consumo.km_final = 2100;
            consumo.litros_combustivel = 20;

            Console.WriteLine("O consumo de combustível é {0} Km/l",
                consumo.Obtem_Consumo());
        }
    }
}
