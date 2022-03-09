using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08.ConsoleApp
{
    internal class LataDeOleo
    {
        public double raio;
        public double altura;

        public double Obtem_Volume()
        {
            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            return volume;
        }
    }
}
