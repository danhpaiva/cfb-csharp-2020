//Métodos que retornam objetos
using System;
class Galinha
{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public Ovo Botar()
    {
        numOvo++;
        return new Ovo(numOvo, nomeGalinha);
    }
}

class Ovo
{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha)
    {
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        
        Console.WriteLine("Ovo criado {0} - {1}", this.numOvo, this.minhaGalinha);
    }
}
class Aula46
{
    static void Main()
    {
        Galinha galinha1 = new Galinha("Beneditas");
        Galinha galinha2 = new Galinha("Felizarda");
        Galinha galinha3 = new Galinha("Maristudes");

        galinha1.Botar();
        galinha1.Botar();
        galinha1.Botar();

        Console.WriteLine();
        galinha2.Botar();

        Console.WriteLine();
        galinha3.Botar();
        galinha3.Botar();
    }
}