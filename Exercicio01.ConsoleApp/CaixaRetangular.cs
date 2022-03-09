using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.ConsoleApp
{
    internal class CaixaRetangular
    {
        public int altura;
        public int largura;
        public int comprimento;

        public double Obtem_Volume()
        {
            double volume = altura * largura * comprimento;

            return volume;
        }
    }
}
