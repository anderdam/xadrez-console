using System;
using Model;
using Model.Exceptions;
using Xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.ColocarPeca(new Rook(tab, Cor.Branca), new Posicao(0, 0));
                tab.ColocarPeca(new Knight(tab, Cor.Branca), new Posicao(0, 1));
                tab.ColocarPeca(new Bishop(tab, Cor.Branca), new Posicao(0, 2));
                tab.ColocarPeca(new King(tab, Cor.Branca), new Posicao(0, 3));
                tab.ColocarPeca(new Queen(tab, Cor.Branca), new Posicao(0, 4));
                tab.ColocarPeca(new Bishop(tab, Cor.Branca), new Posicao(0, 5));
                tab.ColocarPeca(new Knight(tab, Cor.Branca), new Posicao(0, 6));
                tab.ColocarPeca(new Rook(tab, Cor.Branca), new Posicao(0, 7));
                tab.ColocarPeca(new Pawn(tab, Cor.Branca), new Posicao(1, 0));
                tab.ColocarPeca(new Pawn(tab, Cor.Branca), new Posicao(1, 1));
                tab.ColocarPeca(new Pawn(tab, Cor.Branca), new Posicao(1, 2));
                tab.ColocarPeca(new Pawn(tab, Cor.Branca), new Posicao(1, 3));
                tab.ColocarPeca(new Pawn(tab, Cor.Branca), new Posicao(1, 4));
                tab.ColocarPeca(new Pawn(tab, Cor.Branca), new Posicao(1, 5));
                tab.ColocarPeca(new Pawn(tab, Cor.Branca), new Posicao(1, 6));
                tab.ColocarPeca(new Pawn(tab, Cor.Branca), new Posicao(1, 7));

                tab.ColocarPeca(new Rook(tab, Cor.Preta), new Posicao(7, 0));
                tab.ColocarPeca(new Knight(tab, Cor.Preta), new Posicao(7, 1));
                tab.ColocarPeca(new Bishop(tab, Cor.Preta), new Posicao(7, 2));
                tab.ColocarPeca(new King(tab, Cor.Preta), new Posicao(7, 3));
                tab.ColocarPeca(new Queen(tab, Cor.Preta), new Posicao(7, 4));
                tab.ColocarPeca(new Bishop(tab, Cor.Preta), new Posicao(7, 5));
                tab.ColocarPeca(new Knight(tab, Cor.Preta), new Posicao(7, 6));
                tab.ColocarPeca(new Rook(tab, Cor.Preta), new Posicao(7, 7));
                tab.ColocarPeca(new Pawn(tab, Cor.Preta), new Posicao(6, 0));
                tab.ColocarPeca(new Pawn(tab, Cor.Preta), new Posicao(6, 1));
                tab.ColocarPeca(new Pawn(tab, Cor.Preta), new Posicao(6, 2));
                tab.ColocarPeca(new Pawn(tab, Cor.Preta), new Posicao(6, 3));
                tab.ColocarPeca(new Pawn(tab, Cor.Preta), new Posicao(6, 4));
                tab.ColocarPeca(new Pawn(tab, Cor.Preta), new Posicao(6, 5));
                tab.ColocarPeca(new Pawn(tab, Cor.Preta), new Posicao(6, 6));
                tab.ColocarPeca(new Pawn(tab, Cor.Preta), new Posicao(6, 7));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message); ;
            }
        }
    }
}
