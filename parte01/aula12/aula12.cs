//Comando condicional IF
using System;

class Aula12
{
    static void Main()
    {
        //SE (expressão_lógica){executa instrução}
        //10 < 5 = false
        //10 > 5 = true
        // > < >= <= == !=

        int n1, n2, n3, n4, notaFinal;
        n1 = n2 = n3 = n4 = 0;

        string resultado = "Reprovado!";

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
            resultado = "Aprovado!";
        }

        Console.WriteLine("Nota: {0}\tResultado: {1}", notaFinal, resultado);

    }
}