using System;

class Programa
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\tPLACAR");
        Console.ResetColor();

        Times timeA = new Times("Cruzeiro", 6);
        Times timeB = new Times("Atlético", 1);

        Console.WriteLine("\nTime da Casa {0} | {1} X {2} | {3} Time Visitante", timeA.nome, timeA.gol, timeB.gol, timeB.nome);

    }
}

class Times
{
    public string nome;
    public int gol;

    public Times(string nome, int gol)
    {
        this.nome = nome;
        this.gol = gol;
    }

}