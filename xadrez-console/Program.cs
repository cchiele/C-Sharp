﻿using System;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Branca), new Posicao(2, 4));

                //tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 0));

                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
