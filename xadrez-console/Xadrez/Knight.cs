using Model;

namespace Xadrez
{
    class Knight : Peca
    {
        public Knight(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "H";
        }
    }
}

