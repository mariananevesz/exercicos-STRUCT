using System;
class Program
{
    static void Main(string[] args)
    {
        JogadorFutebol jogador1 = new JogadorFutebol();
        jogador1.nome = "Neymar";
        jogador1.idade = 33;
        jogador1.clube = "Santos";
        jogador1.posicao = "Atacante";
        jogador1.salario = 5000000.00;
        jogador1.registrarNumeroCartoesAmarelos();
        jogador1.registrarNumeroCartoesVermelhos();
        jogador1.registrarNumeroCartoesAmarelos();
        jogador1.verificarVinculoClube();
        jogador1.imprimir();
    }
}