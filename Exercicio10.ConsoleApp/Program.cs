using System;

namespace Exercicio10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada media = new MediaPonderada();

            media.nota_01 = 8;
            media.nota_02 = 9;
            media.nota_03 = 10;

            media.peso_01 = 1;
            media.peso_02 = 2;
            media.peso_03 = 3;

            Console.WriteLine("A média ponderada é {0}", 
                media.Obtem_Media());
        }
    }
}
