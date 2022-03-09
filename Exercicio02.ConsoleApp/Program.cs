using System;

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FahrenheitParaCelsius fahrenheit = new FahrenheitParaCelsius();


            fahrenheit.temperatura_fahrenheit = 10;


            Console.WriteLine("A conversão de Fahrenheit para Celsius é {0} °C",
                fahrenheit.Obtem_Temperatura_Celsius());
        }
    }
}
