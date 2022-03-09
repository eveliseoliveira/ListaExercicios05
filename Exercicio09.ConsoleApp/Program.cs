using System;

namespace Exercicio09.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica media = new MediaHarmonica();

            media.nota_01 = 7;
            media.nota_02 = 8;
            media.nota_03 = 5.5;

            Console.WriteLine("A média harmônica é {0}", 
                media.Obtem_Nota());
        }
    }
}
