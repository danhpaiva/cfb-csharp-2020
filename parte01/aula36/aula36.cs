using System;

class Veiculo //Classe Base
{
    public int velocidadeAtual;
    private int velocidadeMaxima;
    protected bool ligado;
    public Veiculo(int velocidadeMaxima)
    {
        velocidadeAtual = 0;
        this.velocidadeMaxima = velocidadeMaxima;
        ligado = false;
    }
    public bool getLigado()
    {
        return ligado;
    }

    public int getVelocidadeMaxima()
    {
        return velocidadeMaxima;
    }
}

class Carro : Veiculo //Classe derivada de Veículo
{
    public string nome;
    public Carro(string nome, int velocidadeMax) : base(velocidadeMax)
    {
        this.nome = nome;

    }
}
class Aula36
{
    static void Main()
    {
        Carro carro = new Carro("Velociraptor", 120);

        Console.WriteLine("Nome: {0}", carro.nome);
        Console.WriteLine("Velocidade Máxima: {0}", carro.getVelocidadeMaxima());
        Console.WriteLine("Ligado: {0}", carro.getLigado());
    }
}