using System;

namespace Exercicio06.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CelsiusParaFahrenheit celsius = new CelsiusParaFahrenheit();

            celsius.temperatura_celsius = 10;

            Console.WriteLine("A conversão de Celsius para Fahrenheit é {0} °F", 
                celsius.Obtem_Temperatura_Fahrenheit());
        }
    }
}
