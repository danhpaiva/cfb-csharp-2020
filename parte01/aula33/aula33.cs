//Public vs Private
using System;

class Jogador
{
    private int energia;
    private string nome;

    public Jogador(string nome)
    {
        this.nome = nome;
        energia = 100;
    }

    public int getEnergia() //Criação do método para retornar uma propriedade privada
    {
        return energia;
    }

    public string getNome() //Criação do método para retornar uma propriedade privada
    {
        return nome;
    }

    public void setEnergia(int e)
    {
        if (e < 0)
        {
            if (energia + e < 0)
                energia = 0;
            else
                energia += e; //Se for negativo: o + é para mudar o valor de - porque menos com menos é mais( - - = + )
        }
        else if (e > 0)
        {
            if (energia + e > 100)
                energia = 100;
            else
                energia += e;
        }
    }
}
class Aula33
{
    static void Main()
    {
        Console.WriteLine("\tJogador 1");
        Jogador j1 = new Jogador("Paiva");

        j1.setEnergia(-30); //valor de energia 70
        j1.setEnergia(-30); //40
        j1.setEnergia(-30); //10
        j1.setEnergia(-30); //0

        Console.WriteLine("Nome: {0}", j1.getNome());
        Console.WriteLine("Energia: {0}", j1.getEnergia());

        Console.WriteLine("\tJogador 2");
        Jogador j2 = new Jogador("Marco");

        j2.setEnergia(-30);
        j2.setEnergia(40);

        Console.WriteLine("Nome: {0}", j2.getNome());
        Console.WriteLine("Energia: {0}", j2.getEnergia());
    }
}