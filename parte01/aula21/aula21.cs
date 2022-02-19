//Loop Do While
using System;

class Aula21
{
    static void Main()
    {
        string senha = "123";
        string senhaUser;
        int tentativas = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Informe a senha: ");
            senhaUser = Console.ReadLine();
            tentativas++;
        } while (senha != senhaUser);

        Console.Clear();
        Console.WriteLine("Senha Correta! Número de tentativas: {0}", tentativas);
    }
}