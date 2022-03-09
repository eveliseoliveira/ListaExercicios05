using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07.ConsoleApp
{
    internal class Vendedor
    {
        public double salario_base;
        public double total_vendas;
        public double porcentagem_comicao;

        public double Obtem_Salario()
        {
            double porcentagem = porcentagem_comicao / 100;

            double salario = total_vendas * porcentagem + (salario_base);

            return salario;
        }
    }
}
