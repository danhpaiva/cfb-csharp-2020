//Argumento params
using System;

class Aula27
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green; //Mudar a cor do título
        Console.WriteLine("\nZero parâmetros: ");
        Console.ResetColor(); //Resetar a cor
        Somar();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nApenas um parâmetro: ");
        Console.ResetColor();
        Somar(10);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nMais de 1 parâmetro: ");
        Console.ResetColor();
        Somar(10, 10, 10, 10, 11, 10);
    }

    static void Somar(params int[] n)
    {
        int resultado = 0;

        if (n.Length < 1)
        {
            Console.WriteLine("\n\tNão existem valores a serem somados!");
        }
        else if (n.Length < 2)
        {
            Console.WriteLine("\n\tValores insuficientes para a soma: {0}", n[0]);
        }
        else
        {
            for (int i = 0; i < n.Length; i++)
            {
                resultado += n[i];
            }
            Console.WriteLine("\n\tA soma dos valores é: {0}", resultado);
        }

    }
}