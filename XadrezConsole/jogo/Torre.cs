using tabuleiro;

namespace jogo
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Color cor) : base(tab, cor)
        {


        }

        public override string ToString()
        {
            return "T";
        }
    }
}
