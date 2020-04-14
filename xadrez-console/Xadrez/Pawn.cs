using Model;

namespace Xadrez
{
    class Pawn : Peca
    {
        public Pawn(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "P";
        }
    }
}