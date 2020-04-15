using System;
using Model;
using xadrez_console;
using Xadrez;

namespace Xadrez
{
    class PartidaXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPeca();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQtdMovimentos();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
        }

        private void ColocarPeca()
        {
            Tab.ColocarPeca(new Rook(Tab, Cor.Preta), new PosicaoXadrez('a', 1).toPosition());
            Tab.ColocarPeca(new Knight(Tab, Cor.Preta), new PosicaoXadrez('b', 1).toPosition());
            Tab.ColocarPeca(new Bishop(Tab, Cor.Preta), new PosicaoXadrez('c', 1).toPosition());
            Tab.ColocarPeca(new King(Tab, Cor.Preta), new PosicaoXadrez('d', 1).toPosition());
            Tab.ColocarPeca(new Queen(Tab, Cor.Preta), new PosicaoXadrez('e', 1).toPosition());
            Tab.ColocarPeca(new Bishop(Tab, Cor.Preta), new PosicaoXadrez('f', 1).toPosition());
            Tab.ColocarPeca(new Knight(Tab, Cor.Preta), new PosicaoXadrez('g', 1).toPosition());
            Tab.ColocarPeca(new Rook(Tab, Cor.Preta), new PosicaoXadrez('h', 1).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Preta), new PosicaoXadrez('a', 2).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Preta), new PosicaoXadrez('b', 2).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Preta), new PosicaoXadrez('c', 2).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Preta), new PosicaoXadrez('d', 2).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Preta), new PosicaoXadrez('e', 2).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Preta), new PosicaoXadrez('f', 2).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Preta), new PosicaoXadrez('g', 2).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Preta), new PosicaoXadrez('h', 2).toPosition());

            Tab.ColocarPeca(new Rook(Tab, Cor.Branca), new PosicaoXadrez('a', 8).toPosition());
            Tab.ColocarPeca(new Knight(Tab, Cor.Branca), new PosicaoXadrez('b', 8).toPosition());
            Tab.ColocarPeca(new Bishop(Tab, Cor.Branca), new PosicaoXadrez('c', 8).toPosition());
            Tab.ColocarPeca(new King(Tab, Cor.Branca), new PosicaoXadrez('d', 8).toPosition());
            Tab.ColocarPeca(new Queen(Tab, Cor.Branca), new PosicaoXadrez('e', 8).toPosition());
            Tab.ColocarPeca(new Bishop(Tab, Cor.Branca), new PosicaoXadrez('f', 8).toPosition());
            Tab.ColocarPeca(new Knight(Tab, Cor.Branca), new PosicaoXadrez('g', 8).toPosition());
            Tab.ColocarPeca(new Rook(Tab, Cor.Branca), new PosicaoXadrez('h', 8).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Branca), new PosicaoXadrez('a', 7).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Branca), new PosicaoXadrez('b', 7).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Branca), new PosicaoXadrez('c', 7).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Branca), new PosicaoXadrez('d', 7).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Branca), new PosicaoXadrez('e', 7).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Branca), new PosicaoXadrez('f', 7).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Branca), new PosicaoXadrez('g', 7).toPosition());
            Tab.ColocarPeca(new Pawn(Tab, Cor.Branca), new PosicaoXadrez('h', 7).toPosition());
        }
    }
}
