using System;
class Program
{
    static void Main(string[] args)
    {
        // JogadorFutebol jogador1 = new JogadorFutebol();
        // jogador1.nome = "Neymar";
        // jogador1.idade = 33;
        // jogador1.clube = "Santos";
        // jogador1.posicao = "Atacante";
        // jogador1.salario = 5000000.00;
        // jogador1.registrarNumeroCartoesAmarelos();
        // jogador1.registrarNumeroCartoesVermelhos();
        // jogador1.registrarNumeroCartoesAmarelos();
        // jogador1.verificarVinculoClube();
        // jogador1.imprimir();

        EquipeEsports equipe1 = new EquipeEsports();
        equipe1.nome = "Corinthians";
        equipe1.jogo = "Brasileirão";
        equipe1.pais = "Brasil";
        equipe1.dataEstreia = new DateTime(2026, 1, 1);
        equipe1.registrarCampeonatoVencido(1000);
        equipe1.registrarCampeonatoVencido(1200);
        equipe1.verificarAnoEstreia();
        equipe1.imprimir();
    }
}
