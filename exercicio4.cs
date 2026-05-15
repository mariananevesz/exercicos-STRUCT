using System;
public struct Professor
{
    public string nome;
    public string disciplina;
    public int cargaHoraria;
    public double salario;
    public int quantidadeFaltas;

    public void reajusteSalarialEmValor(double valor)
    {
        salario += valor;
    }

    public void reajusteSalarialEmPorcentagem(double porcentagem)
    {
        salario += salario * porcentagem / 100;
    }

    public void descontoSalarialPorFaltaEmValor(double valor)
    {
        salario -= valor;
    }

    public void descontoSalarialPorFaltaEmPorcentagem(double porcentagem)
    {
        salario -= salario * porcentagem / 100;
    }

    public void aumentarCargaHorariaDeTrabalho(int horas, double valorReajuste)
    {
        cargaHoraria += horas;
        reajusteSalarialEmValor(valorReajuste);
    }

    public void imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Disciplina: " + disciplina);
        Console.WriteLine("Carga horária: " + cargaHoraria);
        Console.WriteLine("Salário: " + salario);
        Console.WriteLine("Quantidade de faltas: " + quantidadeFaltas);
    }
}