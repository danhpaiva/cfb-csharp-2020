using System;

class Aula51
{
    static void Main(string[] args)
    {
        int resultado = 0;

        for (int i = 0; i < args.Length; i++)
        {
            resultado += int.Parse(args[i]); //Typecast
        }

        Console.WriteLine("Soma: {0}", resultado);
    }
}