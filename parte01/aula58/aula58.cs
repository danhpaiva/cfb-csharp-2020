//Coleção List - Parte 02
using System;
using System.Collections.Generic;

class aula58
{
    static void Main()
    {
        List<string> carros1 = new List<string>();
        string[] carros2 = new string[10];

        carros1.Add("Golf");
        carros1.Add("HRV");
        carros1.Add("Focus");
        carros1.Add("Argo");
        carros1.Add("HRV");

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

        carros1.Insert(1, "Cruze"); //Inserir na posicao 1 o Cruze

        int localizacao = carros1.LastIndexOf("HRV");

        /*
        carros1.RemoveAt(0);

        if (carros1.Remove("Argo"))
        {
            Console.WriteLine("Argo removido da lista!");
        }
        else
        {
            Console.WriteLine("Carro não removido!");
        }
        */

        //carros1.Reverse(); Inverter lista

        carros1.Sort(); //Ordenar lista

        int tamanho = carros1.Count;

        carros1.Capacity = 15;
        int capacidade = carros1.Capacity;

        Console.WriteLine("Tamanho da lista: {0}", tamanho);
        Console.WriteLine("Capacidade: {0}", capacidade);

        foreach (string c in carros1)
        {
            Console.WriteLine("Carro: {0}", c);
        }

        string carro = "HRV";
        int posicao = 0;

        posicao = carros1.IndexOf(carro);
        Console.WriteLine("Carro {0} está na posição {1}", carro, posicao);
        Console.WriteLine("Último HRV está na posição {0}", localizacao);
    }
}