using System;

public class Aluno
{
    public int matricula;
    public string nome;
    public int nota;

    public Aluno()
    {
        matricula = 0;
        nome = "";
        nota = 100;
    }
}

class Cadastro
{
    static void Main()
    {
        Aluno aluno = new Aluno();
        string situacao = "Aprovado";

        Console.WriteLine("\nInforme a matrícula: ");
        aluno.matricula = int.Parse(Console.ReadLine());

        Console.WriteLine("\nInforme o nome: ");
        aluno.nome = Console.ReadLine();

        Console.WriteLine("\nInforme a nota: ");
        aluno.nota = int.Parse(Console.ReadLine());

        //Condição para verificar a nota do aluno
        if (aluno.nota < 60)
            situacao = "Reprovado";

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\nDados:");
        Console.ResetColor();

        Console.WriteLine("\nMatrícula: {0}\nNome:{1}\nNota:{2}\nSituação: {3}", aluno.matricula, aluno.nome, aluno.nota, situacao);
    }
}