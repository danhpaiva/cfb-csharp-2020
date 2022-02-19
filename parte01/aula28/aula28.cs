//Classes e Objetos
using System;

public class Jogador
{
    public int energia = 100;
    public bool vivo = true;
}
class Aula28
{
    static void Main()
    {
        Jogador atacante = new Jogador(); //Instanciando objeto
        Jogador goleiro = new Jogador();

        atacante.energia = 50;
        goleiro.energia = 80;

        Console.WriteLine("Energia do atacante: {0}", atacante.energia);
        Console.WriteLine("Energia do goleiro: {0}", goleiro.energia);
    }
}