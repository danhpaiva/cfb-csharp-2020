//Classes e Métodos Abstratos
using System;

abstract class Veiculo //Classe base abstrata: Não posso instanciar objetos de classes abstratas
{
    protected int velocidadeMaxima;
    protected int velocidadeAtual;
    protected bool ligado;

    public Veiculo()
    {
        ligado = false;
        velocidadeAtual = 0;
    }
    public void setLigado(bool ligado) //Método que não é abstrato com funcionalidade
    {
        this.ligado = ligado;
    }

    public int getVelocidadeAtual()
    {
        return velocidadeAtual;
    }

    abstract public void Aceleracao(int multiplicador); //Método abstrato não implementa funcionalidade

}

class Carro : Veiculo
{
    public Carro()
    {
        velocidadeMaxima = 120;
    }

    override public void Aceleracao(int multiplicador)
    {
        velocidadeAtual += 10 * multiplicador;
    }
}
class Aula39
{
    static void Main()
    {
        Carro carro1 = new Carro();

        Console.WriteLine("Velocidade atual: {0}", carro1.getVelocidadeAtual());

        carro1.Aceleracao(1);

        Console.WriteLine("Velocidade atual: {0}", carro1.getVelocidadeAtual());

        carro1.Aceleracao(1);
        carro1.Aceleracao(1);

        Console.WriteLine("Velocidade atual: {0}", carro1.getVelocidadeAtual());

        carro1.Aceleracao(-1);
        Console.WriteLine("Velocidade atual: {0}", carro1.getVelocidadeAtual());
    }
}