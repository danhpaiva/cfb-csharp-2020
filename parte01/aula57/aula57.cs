//Coleção List - Parte 01 - "Um array dinâmico..."
using System;
using System.Collections.Generic;

class aula57
{
    static void Main()
    {
        List<string> carros1 = new List<string>();
        string[] carros2 = new string[10];

        carros1.Add("Golf");
        carros1.Add("HRV");
        carros1.Add("Focus");
        carros1.Add("Argo");

        // carros2.AddRange(carros1); Carro 2 recebe os elementos de carro 1

        // carros2.Clear(); Limpa todos os elementos da lista

        if (carros1.Contains("Gol"))
        {
            Console.WriteLine("Elemento está na lista.");
        }
        else
        {
            Console.WriteLine("Elemento não está na lista.");
        }

        carros1.CopyTo(carros2, 2); //Para onde quero copiar e a partir de qual posição

        foreach (string c in carros1)
        {
            Console.WriteLine("Carro: {0}", c);
        }

        string carro = "HRV";
        int posicao = 0;

        posicao = carros1.IndexOf(carro);
        Console.WriteLine("Carro {0} está na posição {1}", carro, posicao);
    }
}