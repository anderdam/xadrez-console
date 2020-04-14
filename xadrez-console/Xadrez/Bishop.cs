using Model;

namespace Xadrez
{
    class Bishop : Peca
    {
        public Bishop(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
