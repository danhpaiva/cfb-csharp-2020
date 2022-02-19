//Métodos
using System;

class Aula24
{
    static void Main()
    {
        int v1, v2, r;

        Console.WriteLine("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        v2 = int.Parse(Console.ReadLine());

        r = Somar(v1, v2);

        Console.WriteLine("A soma de {0} e {1} é {2}", v1, v2, r);
    }

    static int Somar(int n1, int n2)
    {
        int resultado = n1 + n2;
        return resultado;
    }
}