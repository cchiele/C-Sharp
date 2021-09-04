using System;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class PartidaXadrez
    {
        public Tabuleiro Tabuleiro { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }

        public PartidaXadrez()
        {
            this.Tabuleiro = new Tabuleiro(8, 8);
            this.Turno = 1;
            this.JogadorAtual = Cor.Branca;
            this.Terminada = false;

            this.IniciarPartida();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = this.Tabuleiro.RetirarPeca(origem);
            p.IncrementarQteMovimentos();
            Peca PecaCapturada = this.Tabuleiro.RetirarPeca(destino);
            this.Tabuleiro.ColocarPeca(p, destino);
        }

        public void IniciarPartida()
        {
            this.Tabuleiro.ColocarPeca(new Torre(this.Tabuleiro, Cor.Preta), new PosicaoXadrez('c', 1).ToPosicao());
            this.Tabuleiro.ColocarPeca(new Torre(this.Tabuleiro, Cor.Preta), new PosicaoXadrez('d', 1).ToPosicao());
        }


    }
}
