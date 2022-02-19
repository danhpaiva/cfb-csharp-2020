//Operadores e Operações
using System;

class Aula05
{
    static void Main()
    {
        /*
          > <  >= <= !=
         int res = (10 + 5) * 2;
         bool res = 10 != 5;
         num++; num += 1; num = num + 1; + - * /
         & = AND / E
         | = OR / OU
        */

        bool res = (5 > 3) | (10 < 5);
        bool res2 = (5 > 3) & (10 < 5);

        Console.WriteLine(res);
        Console.WriteLine(res2);
    }
}