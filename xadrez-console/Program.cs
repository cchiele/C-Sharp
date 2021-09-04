using System;
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
                PartidaXadrez PartidaXadrez = new PartidaXadrez();

                while (!PartidaXadrez.Terminada)
                {
                    Tela.ImprimirTabuleiro(PartidaXadrez.Tabuleiro);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    PartidaXadrez.ExecutarMovimento(origem, destino);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
