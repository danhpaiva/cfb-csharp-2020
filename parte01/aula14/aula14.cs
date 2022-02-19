//IF aninhado
using System;
class Aula14
{
    static void Main()
    {
        int n1, n2, n3, n4, notaFinal;
        n1 = n2 = n3 = n4 = 0;

        string resultado;

        Console.WriteLine("Informe a primeira nota: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a terceira nota: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a quarta nota: ");
        n4 = int.Parse(Console.ReadLine());

        notaFinal = n1 + n2 + n3 + n4;

        if (notaFinal >= 60)
        {
            if (notaFinal >= 90)
            {
                if (notaFinal >= 99)
                    resultado = "Aprovado com super louvor!";
                else
                    resultado = "Aprovado com louvor!";
            }
            else
                resultado = "Aprovado!";
        }
        else
        {
            if (notaFinal >= 40)
                resultado = "Recuperação";
            else
                resultado = "Reprovado!";
        }

        Console.WriteLine("Nota: {0}\tResultado: {1}", notaFinal, resultado);

    }
}