//Namespaces
using System;

namespace Calc1
{
    class CalcularArea
    {
        public static float Quadrado(float baseQuadrado, float altura)
        {
            if (baseQuadrado == 0 || altura == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a 0(zero)");
            }
            return baseQuadrado * altura;
        }
    }
}

namespace Calc2
{
    class CalcularArea
    {
        public static float Quadrado(float baseQuadrado, float altura)
        {
            if (baseQuadrado == 0 || altura == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a 0(zero)");
            }
            return baseQuadrado * altura;
        }
    }
}
class Aula54
{
    static void Main()
    {
        float area = 0;

        try
        {
            area = Calc1.CalcularArea.Quadrado(0, 5f);
            Console.WriteLine("Área do quadrado: {0}", area);
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro: {0}", e.Message);
        }
        finally
        {
            Console.WriteLine("Fim do processo!");
        }
    }
}