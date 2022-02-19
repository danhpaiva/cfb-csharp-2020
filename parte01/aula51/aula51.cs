//Argumentos de entrada do programa
using System;

class Aula51
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
            Console.WriteLine("Quantidade de argumentos: {0}", args.Length);
        else
            Console.WriteLine("Não foram passados argumentos.");

        Console.WriteLine();

        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("Posicação: {0}", i);
            Console.WriteLine("Conteúdo: {0}", args[i]);
            Console.WriteLine();
        }
    }
}