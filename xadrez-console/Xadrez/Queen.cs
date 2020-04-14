using Model;

namespace Xadrez
{
    class Queen : Peca
    {
        public Queen(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "Q";
        }
    }
}
