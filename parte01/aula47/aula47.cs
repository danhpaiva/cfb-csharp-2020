//Sobrecarga de Métodos
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
}
class Aula47
{
    static void Main()
    {
        Calc calculadora = new Calc();

        var resultado = calculadora.Somar(10, 5);

        Console.WriteLine(resultado);

        var resultado2 = calculadora.Somar(10.2, 5.4, 3.5);

        Console.WriteLine("Resultado: {0}", resultado2);

        var resultado3 = calculadora.Somar(10, 20, 30, 40, 25, 25);

        Console.WriteLine("Resultado: {0}", resultado3);
    }
}