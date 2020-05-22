using tabuleiro;

namespace jogo
{
    class Rainha : Peca
    {
        public Rainha(Tabuleiro tab, Color cor) : base(tab, cor)
        {


        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
