//Struct - É um tipo - Permite armazenar várias tipos de dados
using System;

struct Carro
{
    public string marca;
    public string modeloCarro;
    public string cor;

    public Carro(string marca, string modeloCarro, string cor)
    {
        this.marca = marca;
        this.modeloCarro = modeloCarro;
        this.cor = cor;
    }

    public void Informacao()
    {
        Console.WriteLine("Marca: {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modeloCarro);
        Console.WriteLine("Cor: {0}", this.cor);
    }
}
class Aula44
{
    static void Main()
    {
        //01 Forma
        Console.WriteLine("Carro 1:");
        Carro c1;

        c1.marca = "VW";
        c1.modeloCarro = "Golf";
        c1.cor = "Azul";

        Console.WriteLine("Marca: {0}", c1.marca);
        Console.WriteLine("Modelo: {0}", c1.modeloCarro);
        Console.WriteLine("Cor: {0}", c1.cor);

        Console.WriteLine();

        //02 Forma
        Console.WriteLine("Carro 2:");
        Carro c2 = new Carro("Honda", "HRV", "Prata");

        Console.WriteLine("Marca: {0}", c2.marca);
        Console.WriteLine("Modelo: {0}", c2.modeloCarro);
        Console.WriteLine("Cor: {0}", c2.cor);

        Console.WriteLine();

        //03 Forma
        Console.WriteLine("Carro 3:");
        Carro c3 = new Carro("Tesla", "Monster", "Vermelho");

        c3.Informacao();
    }
}