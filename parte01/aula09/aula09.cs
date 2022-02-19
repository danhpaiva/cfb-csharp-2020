//Operações de Bitwise
using System;

class Aula09
{
    static void Main()
    {
        // << Dobrar  >>Metade
        int numero = 10, numero2 = 18, numero3 = 10, numero4 = 36;

        numero = numero << 1;
        numero2 = numero2 >> 1;

        Console.WriteLine("Valor de número: {0}", numero);
        Console.WriteLine("Valor de número 2: {0}", numero2);

        numero3 = numero3 << 2;
        numero4 = numero4 >> 2;

        Console.WriteLine("Valor de número 3: {0}", numero3);
        Console.WriteLine("Valor de número 4: {0}", numero4);
    }
}