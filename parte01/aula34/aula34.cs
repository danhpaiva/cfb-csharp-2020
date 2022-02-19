//Herança
using System;

class Veiculo //Classe Base
{
    public int rodas;
    public int velMax;
    private bool ligado;

    public void Ligar()
    {
        ligado = true;
    }

    public void Desligar()
    {
        ligado = false;
    }

    public string getLigado()
    {
        if (ligado)
            return "SIM";
        else
            return "NÃO";
    }
}

class Carro : Veiculo //Classe derivada Carro herda a Classe Veiculo
{
    public string nome, cor;
    public Carro(string nome, string cor)
    {
        Desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}
class Aula34
{
    static void Main()
    {
        Carro c1 = new Carro("Gol", "Vermelho");

        Console.WriteLine("Nome: {0}", c1.nome);
        Console.WriteLine("Cor: {0}", c1.cor);
        Console.WriteLine("Quantidade de rodas: {0}", c1.rodas);
        Console.WriteLine("Velocidade Máxima: {0}", c1.velMax);
        Console.WriteLine("Ligado: {0}", c1.getLigado());
    }
}