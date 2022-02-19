//Classe Sealed - Não pode haver herança
using System;

sealed class Veiculo
{
    public string nome, modelo;
    public int rodas;

    public Veiculo(string nome, string modelo, int rodas)
    {
        this.nome = nome;
        this.modelo = modelo;
        this.rodas = rodas;
    }
}
class Aula40
{
    static void Main()
    {
       Veiculo carro = new Veiculo("BMW", "X6", 4); 
       Console.WriteLine("\nVeículo");

       Console.WriteLine("Nome: {0} ", carro.nome);
       Console.WriteLine("Modelo: {0} ", carro.modelo);
       Console.WriteLine("Quantidade de rodas: {0} ", carro.rodas);

    }
}