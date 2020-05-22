using System;
using System.Reflection.PortableExecutable;
using tabuleiro;
using jogo;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PosJogo pos = new PosJogo('a', 1);

                Console.WriteLine(pos);

                Console.WriteLine(pos.toPosicao());
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
