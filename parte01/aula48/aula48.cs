//Recursividade
using System;

class Calc
{
    public int Somar(params int[] n)
    {
        int somador = 0;
        for (int i = 0; i < n.Length; i++)
        {
            somador += n[i];
        }
        return somador;
    }

    public double Somar(params double[] n)
    {
        double somador = 0;
        for (int i = 0; i < n.Length; i++)
        {
            somador += n[i];
        }
        return somador;
    }

    public int Fatorial(int n) //Recursividade - Fatorial 5! = 5*4*3*2*1
    {
        int resultado;
        if (n <= 1)
        {
            resultado = 1; //Controle de saída
        }
        else
        {
            resultado = n * Fatorial(n - 1);
        }

        return resultado;
    }
}
class Aula48
{
    static void Main()
    {
        Calc calculadora = new Calc();

        var resultado = calculadora.Fatorial(5);

        Console.WriteLine(resultado);

        var resultado2 = calculadora.Fatorial(3);

        Console.WriteLine(resultado2);

        var resultado3 = calculadora.Fatorial(10);

        Console.WriteLine(resultado3);
    }
}