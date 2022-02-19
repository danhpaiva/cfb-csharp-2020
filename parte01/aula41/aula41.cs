using System;

class Carro
{
    private int velocidadeMax;
    public int velMax //Não é obrigatório implementar um get e um set
    {
        get //Read only
        {
            return velocidadeMax;
        }
        set //Write only
        {
            if (value < 0)
            {
                velocidadeMax = 0;
            }
            else if (value > 300)
            {
                velocidadeMax = 300;
            }
            else
            {
                velocidadeMax = value;
            }
        }
    }

    public Carro()
    {
        velMax = 120;
    }
}

class Aula41
{
    static void Main()
    {
        Carro carro1 = new Carro();

        Console.WriteLine("Velocidade: {0} ", carro1.velMax);

        carro1.velMax = 200;

        Console.WriteLine("Velocidade: {0} ", carro1.velMax);

        carro1.velMax = 5000; //Limite é 300

        Console.WriteLine("Velocidade: {0} ", carro1.velMax);
    }
}