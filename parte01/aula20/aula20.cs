//Loop While
using System;

class Aula20
{
    static void Main()
    {
        int[] num = new int[10];

        int i = 9;

        while (i > 0)
        {
            num[i] = 0;
            Console.WriteLine(num[i]);
            i--;
        }

        Console.WriteLine("Fim do loop!");
    }
}