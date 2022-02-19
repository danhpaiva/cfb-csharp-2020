//Lendo valores do teclado
using System;

class Aula08
{
    static void Main()
    {
        int v1, v2, soma;

        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine()); //TypeCast

        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine()); //TypeCast

        soma = v1 + v2;

        Console.WriteLine("Resultado: {0}", soma);
    }
}