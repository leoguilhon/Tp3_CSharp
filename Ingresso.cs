using System;

public class Ingresso
{
    private string nomeDoShow;
    private double preco;
    private int quantidadeDisponivel;

    public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
    {
        this.nomeDoShow = nomeDoShow;
        this.preco = preco;
        this.quantidadeDisponivel = quantidadeDisponivel;
    }

    public void AlterarPreco(double novoPreco)
    {
        preco = novoPreco;
    }

    public void AlterarQuantidade(int novaQuantidade)
    {
        quantidadeDisponivel = novaQuantidade;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Show: {nomeDoShow}\nPreço: R$ {preco:F2}\nQuantidade Disponível: {quantidadeDisponivel}");
    }

    // Exercício 5 - Getters e Setters
    public string GetNomeDoShow()
    {
        return nomeDoShow;
    }

    public void SetNomeDoShow(string novoNome)
    {
        nomeDoShow = novoNome;
    }

    public double GetPreco()
    {
        return preco;
    }

    public void SetPreco(double novoPreco)
    {
        preco = novoPreco;
    }

    public int GetQuantidadeDisponivel()
    {
        return quantidadeDisponivel;
    }

    public void SetQuantidadeDisponivel(int novaQtd)
    {
        quantidadeDisponivel = novaQtd;
    }
}
