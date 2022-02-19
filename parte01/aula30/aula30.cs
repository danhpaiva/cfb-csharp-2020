//Sobrecarga de Construtores
using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador() //Método construtor sem parâmetro
    {
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }
    public Jogador(string name) //Método construtor com parâmetro
    {
        energia = 100;
        vivo = true;
        nome = name;
    }

    public Jogador(string name, int energy) //Método construtor com parâmetros
    {
        energia = energy;
        vivo = true;
        nome = name;
    }

    public Jogador(string name, int energy, bool life) //Método construtor com parâmetro
    {
        energia = energy;
        vivo = life;
        nome = name;
    }

    public void Info()
    {
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("Energia jogador: {0}", energia);
        Console.WriteLine("Status jogador: {0}\n", vivo);
    }
}
class Aula30
{
    static void Main()
    {
        Jogador atacante = new Jogador(); //Instanciando objeto
        Jogador goleiro = new Jogador("Fábio");
        Jogador volante = new Jogador("Gabriel", 100);
        Jogador meia = new Jogador("Paiva", 0, false);

        atacante.Info();
        goleiro.Info();
        volante.Info();
        meia.Info();
    }
}