//Passagem por valor e por referência
using System;

class Aula25
{
    static void Main()
    {
        int num = 50;

        dobrar2(num); //Passagem por valor
        Console.WriteLine("Passagem por valor: {0}", num);

        dobrar1(ref num); //Passagem por Referência
        Console.WriteLine("Passagem por referência: {0}", num);
    }

    static void dobrar1(ref int valor) //Passagem por referência
    {
        valor *= 2;
    }

    static void dobrar2(int valor) //Passagem por valor
    {
        valor *= 2;
    }
}