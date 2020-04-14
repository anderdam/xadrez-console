using Model;

namespace Xadrez
{
    class King : Peca
    {
        public King(Tabuleiro tab, Cor cor) : base (cor, tab)
        {
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
