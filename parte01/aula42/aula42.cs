//Indexadores de Classes
using System;

class Carro
{
    private int[] velocidadeMax = new int[5] { 80, 120, 160, 240, 300 };
    public int this[int i] //Indexador do tipo int
    {
        get
        {
            return velocidadeMax[i];
        }
        set
        {
            if (value < 0)
            {
                velocidadeMax[i] = 0;
            }
            else if (value > 300)
            {
                velocidadeMax[i] = 300;
            }
            else
            {
                velocidadeMax[i] = value;
            }
        }
    }
    public Carro()
    {

    }
}

class Aula42
{
    static void Main()
    {
        Carro carro1 = new Carro();

        Console.WriteLine("\tCarro no índice 0");
        Console.WriteLine("Velocidade: {0} ", carro1[0]);

        carro1[0] = 200;

        Console.WriteLine("Velocidade: {0} ", carro1[0]);

        carro1[0] = 200;

        Console.WriteLine("\tCarro no índice 3");
        Console.WriteLine("Velocidade: {0} ", carro1[3]);

        carro1[3] = 5000; //Limite 300

        Console.WriteLine("Velocidade: {0} ", carro1[3]);
    }
}