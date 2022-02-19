//Exceções - Try Catch Finally - Parte 01
using System;

class Aula52
{
    static void Main()
    {
        int n1, n2, resultado;
        resultado = n2 = n1 = 0;

        n1 = 10;
        n2 = 0;

        try
        {
            resultado = n1 / n2; //Operação que pode ser crítica
            Console.WriteLine("{0}/{1} = {2}", n1, n2, resultado);
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro: {0}", e.Message);
            Console.WriteLine("Ex: {0}", e.GetType());
        }
    }
}