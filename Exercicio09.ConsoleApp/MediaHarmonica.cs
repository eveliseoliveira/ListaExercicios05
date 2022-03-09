using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09.ConsoleApp
{
    internal class MediaHarmonica
    {
        public double nota_01;
        public double nota_02;
        public double nota_03;

        public double Obtem_Nota()
        {
            double media = (3 / ((1 / nota_01) + (1 / nota_02) + (1 / nota_03)));

            return media;
        }
    }
}
