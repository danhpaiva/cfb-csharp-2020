//Array de estruturas
using System;

struct Carro
{
    public string cor, modeloCarro;

    public void Informacao()
    {
        Console.WriteLine("Cor: {0}", this.cor);
        Console.WriteLine("Modelo: {0}", this.modeloCarro);
        Console.WriteLine();
    }
}
class Aula45
{
    static void Main()
    {
        Console.WriteLine("\t\tCarros\n");
        Carro[] carros = new Carro[4];

        carros[0].modeloCarro = "HRV";
        carros[0].cor = "Prata";

        carros[1].modeloCarro = "Golf";
        carros[1].cor = "Azul";

        carros[2].modeloCarro = "Jetta";
        carros[2].cor = "Branco";

        carros[3].modeloCarro = "Argo";
        carros[3].cor = "Preto";

        for (int i = 0; i < carros.Length; i++)
        {
            carros[i].Informacao();
        }
    }
}