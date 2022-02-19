//Interfaces - Não possuem propriedades (campos), não pode conter construtor, não tem membros static
using System;

public interface Veiculo
{
    void Ligar();
    void Desligar();
    void Informacao();
}

public interface Combate
{
    void Disparar();
}

class Carro : Veiculo, Combate
{
    public bool ligado;
    private int municao;
    public Carro()
    {
        setMunicao(100);
    }

    public void Ligar()
    {
        this.ligado = true;
    }

    public void Desligar()
    {
        this.ligado = false;
    }

    public void Informacao() { }

    public void Disparar() { }

    public void setMunicao(int quantidade)
    {
        this.municao = quantidade;
    }
}
class Aula43
{
    static void Main()
    {
        Carro carro = new Carro();
        Console.WriteLine("Status: {0}", carro.ligado);

        carro.ligado = true;

        Console.WriteLine("Status: {0}", carro.ligado);
    }
}