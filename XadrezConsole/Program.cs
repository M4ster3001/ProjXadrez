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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.InsertPeca(new Rei(tab, Color.Branca), new Posicao(0, 0));
                tab.InsertPeca(new Torre(tab, Color.Preta), new Posicao(1, 3));
                tab.InsertPeca(new Rainha(tab, Color.Preta), new Posicao(2, 5));
                tab.InsertPeca(new Rainha(tab, Color.Preta), new Posicao(9, 5));

                Tela.printTab(tab);
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
