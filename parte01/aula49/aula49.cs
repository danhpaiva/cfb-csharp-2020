//Métodos e Variáveis estáticos (static) - Não precisa instanciar o objeto
using System;

class Matematica
{
    public static double pi = 3.14;

    public static int Dobrar(int n)
    {
        return n * 2;
    }
}
class Aula49
{
    static void Main()
    {
        double valorPi = Matematica.pi;
        int num = 10;

        Console.WriteLine(Matematica.Dobrar(num));

        Console.WriteLine(valorPi);
    }
}