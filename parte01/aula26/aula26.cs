//Argumento Out
using System;

class Aula26
{
    static void Main()
    {
        int divid, divis, quoc, rest;

        Console.WriteLine("Informe um dividendo: ");
        divid = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe um divisor: ");
        divis = int.Parse(Console.ReadLine());
        
        quoc = Dividir(divid, divis, out rest);

        Console.WriteLine("{0}/{1}: quociente = {2} e resto {3}", divid, divis, quoc, rest);
    }

    static int Dividir(int dividendo, int divisor, out int resto)
    {
        int quociente = dividendo / divisor;
        resto = dividendo % divisor;

        return quociente;
    }
}