using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.ConsoleApp
{
    internal class Volume_Cilindro
    {
        public double altura;
        public double raio;
        public double Obtem_volume_cilindro()
        {
            double volume = 3.14 * Math.Pow(raio, 2) * altura;

            return volume;
        }
    }
}
