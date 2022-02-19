using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("\tOperações");

        Operacoes m = new Operacoes(10, 5);
        Console.WriteLine("\nMultiplicação: {0}", m.Multiplicacao());

        Operacoes d = new Operacoes(10, 5);
        Console.WriteLine("Divisão: {0}", d.Divisao());
    }
}

class Operacoes
{
    public int valor1, valor2;

    public Operacoes(int valor1, int valor2) //Construtor
    {
        this.valor1 = valor1;
        this.valor2 = valor2;
    }

    public int Multiplicacao()
    {
        return valor1 * valor2;
    }

    public int Divisao()
    {
        return valor1 / valor2;
    }
}