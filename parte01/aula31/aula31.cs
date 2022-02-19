//Classes static
using System;

static public class Jogador //Classe static não pode ter construtor
{
    static public int energia; //Também podemos ter membros static e todos os objetos terão a mesma propriedade
    static public bool vivo;
    static public string nome;

    static public void Iniciar(string name)
    {
        energia = 100;
        vivo = true;
        nome = name;
    }

    static public void Info()
    {
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("Energia jogador: {0}", energia);
        Console.WriteLine("Status jogador: {0}\n", vivo);
    }
}

class Inimigo
{
    static public bool alerta;
    public string nome;

    public Inimigo(string name) //Construtor
    {
        alerta = false;
        nome = name;
    }

    public void Info()
    {
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine();
    }
}
class Aula31
{
    static void Main()
    {
        Jogador.Iniciar("Paiva");
        Jogador.Info();

        Inimigo inimigoUm = new Inimigo("Doido");
        Inimigo inimigoDois = new Inimigo("Maluco");
        Inimigo inimigoTres = new Inimigo("Pirado");

        Inimigo.alerta = true; //Mudando a propriedade de todos os objetos

        inimigoUm.Info();
        inimigoDois.Info();
        inimigoTres.Info();
    }
}