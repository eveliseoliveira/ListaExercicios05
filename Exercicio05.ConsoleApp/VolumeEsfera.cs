using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05.ConsoleApp
{
    internal class VolumeEsfera
    {
        public double raio;

        public double Obtem_Volume()
        {
            double volume = 4 / 3 * Math.PI * Math.Pow(raio, 3);

            return volume;
        }
    }
}
