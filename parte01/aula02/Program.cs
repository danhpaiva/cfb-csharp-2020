//Criando primeiro programa no padrão csharp.net
using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CFB Cursos");

            if (args.GetLength(0) > 0)
            {
                Console.WriteLine(args.GetValue(0)); //Pegar o valor da posição 0
            }

        }
    }
}
