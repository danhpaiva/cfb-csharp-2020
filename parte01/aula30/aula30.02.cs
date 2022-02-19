using System;

class Aluno
{
    public int matricula, nota;
    public string nome, situacao;

    public Aluno()
    {
        matricula = 0;
        nome = "";
        nota = 100;
        situacao = "Aprovado!";
    }

    public Aluno(int Matricula, string Nome, int Nota, string Situacao)
    {
        matricula = Matricula;
        nome = Nome;
        nota = Nota;
        situacao = Situacao;
    }

    public void PreencherDados()
    {
        Console.WriteLine("Informe a matrícula:");
        matricula = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o nome:");
        nome = Console.ReadLine();

        Console.WriteLine("Informe a nota:");
        nota = int.Parse(Console.ReadLine());
    }

    public void ChecarNota()
    {
        if (nota < 40)
            situacao = "Reprovado.";
        else if (nota < 60)
            situacao = "Recuperação.";

    }
    public void ImprimirDados()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta; //Mudar cor
        Console.WriteLine("\tDADOS");
        Console.ResetColor(); //Resetar cor

        Console.WriteLine("\nMatrícula: {0}", matricula);
        Console.WriteLine("Nome do aluno: {0}", nome);
        Console.WriteLine("Nota: {0}", nota);
        Console.WriteLine("Situação: {0}", situacao);
    }
}

class Programa
{
    static void Main()
    {
        Aluno aluno = new Aluno();

        aluno.PreencherDados();
        aluno.ChecarNota();
        Console.Clear();
        aluno.ImprimirDados();

        Aluno aluno_2 = new Aluno(2, "Kennedy", 40, "Reprovado");
        aluno_2.ChecarNota();
        aluno_2.ImprimirDados();
    }
}