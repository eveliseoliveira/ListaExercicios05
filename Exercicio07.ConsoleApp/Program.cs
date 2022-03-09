using System;

namespace Exercicio07.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();

            vendedor.salario_base = 1500;
            vendedor.total_vendas = 7000;
            vendedor.porcentagem_comicao = 1.5;

            Console.WriteLine("O salário total do vendedor é R$ {0}",
                vendedor.Obtem_Salario());
        }
    }
}
