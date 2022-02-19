//Métodos Virtuais
using System;

class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe Base");
    }

    virtual public void Informacao() //Método virtual - Poderá ser usado em outras classes, porém será sobrescrito
    {
        Console.WriteLine("Base");
    }
}

class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("\nConstrutor da classe Derivada 1");
    }

    override public void Informacao() //Método existe na classe base
    {
        Console.WriteLine("Derivada 1");
    }
}

class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("\nConstrutor da classe Derivada 2");
    }
    override public void Informacao() //Método existe na classe base
    {
        Console.WriteLine("Derivada 2");
    }
}

class Aula38
{
    static void Main()
    {
        Base Ref; //Objeto de referência que recebe as propriedades das classes derivadas
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();

        Console.WriteLine();

        Ref = derivada1;
        Ref.Informacao();

        Ref = derivada2;
        Ref.Informacao();
    }
}