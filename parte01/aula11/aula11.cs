//Conversões de tipo (typecast)
using System;

class Aula11
{
    static void Main()
    {
        float n1 = 10.5f;
        int n2 = (int)n1; //type cast

        Console.WriteLine(n2);

        int vInt = 100;
        long vLong = vInt; //Conversão implícita (sem typecast)
        short vShort = (short)vInt; //type cast

        Console.WriteLine(vShort);
    }
}