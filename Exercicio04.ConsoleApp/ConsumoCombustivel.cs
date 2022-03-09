using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.ConsoleApp
{
    internal class ConsumoCombustivel
    {
        public double km_inicial;
        public double km_final;
        public double litros_combustivel;

        public double Obtem_Consumo()
        {
            double km_rodados = km_final - km_inicial;

            double consumo = km_rodados / litros_combustivel;

            return consumo;
        }
    }
}
