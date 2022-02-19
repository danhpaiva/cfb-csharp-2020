//Condicional IF-ELSE
using System;
class Aula13
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

        // >= 60 - Aprovado
        // 59 e 40 - Recuperação 
        // < 40 - Reprovado

        if (notaFinal >= 60)
        {
            resultado = "Aprovado!";
        }
        else if (notaFinal >= 40)
        {
            resultado = "Recuperação!";
        }
        else
        {
            resultado = "Reprovado!";
        }

        Console.WriteLine("Nota: {0}\tResultado: {1}", notaFinal, resultado);

    }
}