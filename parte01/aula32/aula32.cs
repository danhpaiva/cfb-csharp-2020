//Operador This
using System;

class Calculos
{
    public int valorUm;
    public int valorDois;

    public Calculos(int valorUm, int valorDois) //Método Construtor
    {
        this.valorUm = valorUm; //O this mostra que o primeiro valorUm pertence ao objeto e o segundo ao construtor
        this.valorDois = valorDois;
    }
    public int Somar()
    {
        return valorUm + valorDois;
    }
}

class Aula32
{
    static void Main()
    {
        Calculos c = new Calculos(10, 2);

        Console.WriteLine(c.Somar());
    }
}