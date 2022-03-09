using System;

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VolumeEsfera esfera = new VolumeEsfera();
            esfera.raio = 7;

            Console.WriteLine("O volume da esfera é {0} cm³", 
                esfera.Obtem_Volume());
        }
    }
}
