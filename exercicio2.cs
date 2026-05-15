using System;
public struct EquipeEsports
{
    public string nome;
    public string jogo;
    public string pais;
    public DateTime dataEstreia;
    public int numeroCampeonatosVencidos;
    public decimal valorTotalPremiacoes;

    public void registrarCampeonatoVencido(decimal valorPremio)
    {
        numeroCampeonatosVencidos++;
        atualizarValorTotalPremiacoes(valorPremio);
    }

    public void atualizarValorTotalPremiacoes(decimal valor)
    {
        if (valor > 0)
        {
            valorTotalPremiacoes += valor;
        }
    }

    public void verificarAnoEstreia()
    {
        if (dataEstreia.Year == DateTime.Now.Year)
        {
            Console.WriteLine("A equipe é novata no cenário nacional de e-sports.");
        }
        else
        {
            Console.WriteLine("A equipe é veterana no cenário nacional de e-sports.");
        }
    }

    public void imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Jogo: " + jogo);
        Console.WriteLine("Pais: " + pais);
        Console.WriteLine("Data de estreia: " + dataEstreia.ToString("dd/MM/yyyy"));
        Console.WriteLine("Número de campeonatos vencidos: " + numeroCampeonatosVencidos);
        Console.WriteLine("Valor total de premiações: R$ " + valorTotalPremiacoes);
    }
}
