//Construtores e Destrutores
using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(string name) //Método construtor
    {
        energia = 100;
        vivo = true;
        nome = name;
    }

    ~Jogador() //Método destrutor
    {
        Console.WriteLine("\nJogador {0} foi destruído! (deletado)", nome);
    }
}
class Aula29
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do atacante: ");
        string nomeAtacante = Console.ReadLine();

        Jogador atacante = new Jogador(nomeAtacante); //Instanciando objeto

        Jogador goleiro = new Jogador("Paiva");

        atacante.energia = 50; goleiro.energia = 80;

        Console.WriteLine("\nEnergia do atacante {0}: {1}", atacante.nome, atacante.energia);
        Console.WriteLine("\nEnergia do goleiro {0}: {1}", goleiro.nome, goleiro.energia);
    }
}