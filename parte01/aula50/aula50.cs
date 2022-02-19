//Delegates
using System;

delegate int Operacao(int n1, int n2);
class Matematica
{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
}
class Aula50
{
    static void Main()
    {
        int resultado;

        Operacao delegate1 = new Operacao(Matematica.Somar);

        resultado = delegate1(10, 50);

        Console.WriteLine("Soma: {0}", resultado);

        delegate1 = new Operacao(Matematica.Multiplicar);

        resultado = delegate1(10, 50);

        Console.WriteLine("Multiplicação: {0}", resultado);
    }
}