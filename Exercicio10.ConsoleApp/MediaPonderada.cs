using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10.ConsoleApp
{
    internal class MediaPonderada
    {
        public double nota_01;
        public double nota_02;
        public double nota_03;

        public double peso_01;
        public double peso_02;
        public double peso_03;

        public double Obtem_Media()
        {
            double media = (nota_01 * peso_01 + nota_02 * peso_02 + nota_03 * peso_03) 
                / (peso_01 + peso_02 + peso_03);

            return media;
        }
    }
}
