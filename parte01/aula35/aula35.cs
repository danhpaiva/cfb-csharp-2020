//Cadeia de Herança e Construtor da classe base
using System;

class Veiculo //Classe Base
{
    private int rodas;
    public int velMax;
    private bool ligado;

    public Veiculo(int rodas)
    {
        this.rodas = rodas;
    }
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
        //Operador ternario : se for verdadeira retorna a primeira sentança, se for falso a segunda
        return (ligado ? "Sim" : "Não");
    }

    public int getRodas()
    {
        return rodas;
    }

    public void setRodas(int rodas)
    {
        if (rodas < 0)
        {
            this.rodas = 0;
        }
        else if (40 > 0)
        {
            this.rodas = 40;
        }
        else
        {
            this.rodas = rodas;
        }
    }
}

class Carro : Veiculo //Classe derivada Carro herda a Classe Veiculo
{
    public string nome, cor;
    public Carro(string nome, string cor) : base(4)
    {
        Desligar();
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class CarroCombate : Carro
{
    public int municao;

    public CarroCombate() : base("Carro de Combate", "Verde")
    {
        municao = 100;
        velMax = 200;
        setRodas(6);
    }
}
class Aula35
{
    static void Main()
    {
        Carro c1 = new Carro("Gol", "Vermelho");

        //Ligar carro
        c1.Ligar();

        Console.WriteLine("Nome: {0}", c1.nome);
        Console.WriteLine("Cor: {0}", c1.cor);
        Console.WriteLine("Quantidade de rodas: {0}", c1.getRodas());
        Console.WriteLine("Velocidade Máxima: {0}", c1.velMax);
        Console.WriteLine("Ligado: {0}", c1.getLigado());

        Console.WriteLine();

        CarroCombate cc1 = new CarroCombate();

        Console.WriteLine("Nome: {0}", cc1.nome);
        Console.WriteLine("Cor: {0}", cc1.cor);
        Console.WriteLine("Quantidade de rodas: {0}", cc1.getRodas());
        Console.WriteLine("Velocidade Máxima: {0}", cc1.velMax);
        Console.WriteLine("Ligado: {0}", cc1.getLigado());
        Console.WriteLine("Munição: {0}", cc1.municao);
    }
}