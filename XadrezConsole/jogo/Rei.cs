﻿using tabuleiro;

namespace jogo
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Color cor) : base(tab, cor) { 
            

        }

        public override string ToString()
        {
            return "K";
        }
    }
}
