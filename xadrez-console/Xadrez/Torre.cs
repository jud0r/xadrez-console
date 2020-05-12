using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez_console.Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
