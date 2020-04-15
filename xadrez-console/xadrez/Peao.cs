using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        private PartidaDeXadrez partidaDeXadrez;

        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public Peao(Tabuleiro tab, Cor cor, PartidaDeXadrez partidaDeXadrez) : this(tab, cor)
        {
            this.partidaDeXadrez = partidaDeXadrez;
        }

        public override bool[,] movimentosPossiveis()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "P";
        }
    }
}