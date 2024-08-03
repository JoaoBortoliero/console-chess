using console_chess;
using console_chess.tabuleiro;
using xadrez;

try
{
    Tabuleiro tab = new Tabuleiro(8, 8);

    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

    Tela.ImprimirTabuleiro(tab);

    Console.ReadLine();

}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
Console.ReadLine();

