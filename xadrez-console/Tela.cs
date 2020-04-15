﻿using System;
using Model;
using Xadrez;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            System.Console.WriteLine("--------------------------");
            for (int i = 0; i < tab.Linhas; i++)
            {
                System.Console.Write(8 - i + "| ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("-  ");
                    }
                    else
                    {
                        ImprimirPeca(tab.peca(i, j));
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();                
            }
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("   a  b  c  d  e  f  g  h");
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
