using console_chess;
using tabuleiro;
using xadrez;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();

    while (!partida.Terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab);

        Console.Write("\nOrigem: ");
        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

        Console.Clear();
        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

        Console.Write("\nDestino: ");
        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

        partida.ExecutaMovimento(origem, destino);
    }


}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}

//PosicaoXadrez pos = new PosicaoXadrez('c', 7);
//Console.WriteLine(pos);
//Console.WriteLine(pos.ToPosicao());
//Console.ReadLine();

