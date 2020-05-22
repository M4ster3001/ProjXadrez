
namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Color cor { get; protected set; }
        public int qtdeMovimentacao { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Color cor) {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qtdeMovimentacao = 0;
        }
    }
}
