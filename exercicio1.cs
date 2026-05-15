using System;
public struct JogadorFutebol
{
    public string nome;
    public int idade;
    public string clube;
    public int numeroCartoesAmarelos;
    public int numeroCartoesVermelhos;
    public string posicao;
    public double salario;
 
    public void registrarNumeroCartoesAmarelos()
    {
        numeroCartoesAmarelos++;
    }

    public void registrarNumeroCartoesVermelhos()
    {
        numeroCartoesVermelhos++;
    }

    public void verificarVinculoClube()
    {
        if (clube != null && clube != "")
        {
            Console.WriteLine("O jogador tem vínculo com o "+clube);
        }
        else
        {
            Console.WriteLine("O jogador não tem vínculo com nenhum clube");
        }
    }

    public void imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Clube: " + clube);
        Console.WriteLine("Posição: " + posicao);
        Console.WriteLine("Salário: " + salario);
        Console.WriteLine("Número de Cartões Amarelos: " + numeroCartoesAmarelos);
        Console.WriteLine("Número de Cartões Vermelhos: " + numeroCartoesVermelhos);
    }
}