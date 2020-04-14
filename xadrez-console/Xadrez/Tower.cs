using Model;

namespace Xadrez
{
    class Rook : Peca
    {
        public Rook(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
