//Enumeradores (enum)
using System;

class Aula10
{
    //Enumerador
    enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
    static void Main()
    {
        DiasSemana ds = DiasSemana.Domingo;
        DiasSemana dsIndice = (DiasSemana)3;

        int dsInt = (int)DiasSemana.Sexta;

        Console.WriteLine(ds);
        Console.WriteLine(dsIndice);
        Console.WriteLine(dsInt);
    }
}