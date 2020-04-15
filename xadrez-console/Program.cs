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
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.WriteLine();
                    
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosition();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosition();

                    partida.ExecutaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message); ;
            }
        }
    }
}
