using System;
public struct Produto
{
    public string nome;
    public string marca;
    public double preco;
    public int quantidadeEstoque;

    public void aplicarCupomDescontoValor(double valor)
    {
        preco -= valor;
    }

    public void aplicarCupomDescontoPorcentagem(double porcentagem)
    {
        preco -= preco * porcentagem / 100;
    }

    public void verificarQuantidadeEmEstoque()
    {
        if (quantidadeEstoque > 0)
        {
            Console.WriteLine("Produto disponível em estoque.");
        }
        else
        {
            Console.WriteLine("Produto sem estoque.");
        }
    }

    public void imprimir()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Preço: " + preco);
        Console.WriteLine("Quantidade em estoque: " + quantidadeEstoque);
    }
}