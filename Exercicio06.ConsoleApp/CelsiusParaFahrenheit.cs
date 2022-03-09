using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06.ConsoleApp
{
    internal class CelsiusParaFahrenheit
    {
        public int temperatura_celsius;

        public double Obtem_Temperatura_Fahrenheit()
        {
            double conversao = (temperatura_celsius * 1.8) + 32;

            return conversao;
        }

    }
}
