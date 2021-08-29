using System;
using System.Collections.Generic;
using System.Text;
using xadrez_console.tabuleiro.exceptions;

namespace xadrez_console.tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;

            this.Pecas = new Peca[this.Linhas, this.Colunas];
        }

        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca Peca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (this.ExistePeca(pos))
            {
                throw new TabuleiroException("Ja existe uma peca nesta posicao");
            }

            this.Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public bool ExistePeca(Posicao pos)
        {
            this.ValidarPosicao(pos);
            return Peca(pos) != null;
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= this.Linhas || pos.Coluna < 0 || pos.Coluna >= this.Colunas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!this.PosicaoValida(pos))
            {
                throw new TabuleiroException("Posicao invalida");
            }
        }

    }
}
