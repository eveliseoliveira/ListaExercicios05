using System;

namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Volume_Cilindro cilindro = new Volume_Cilindro();


            cilindro.altura = 3;
            cilindro.raio = 1.5;


            Console.WriteLine("O volume do cilindro é {0} cm³",
                cilindro.Obtem_volume_cilindro());
        }
    }
}
