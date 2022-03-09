using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.ConsoleApp
{
    internal class FahrenheitParaCelsius
    {
        public int temperatura_fahrenheit;
        public double Obtem_Temperatura_Celsius()
        {
            double conversao = (temperatura_fahrenheit - 32) / 1.8;

            return conversao;
        }
    }
}
