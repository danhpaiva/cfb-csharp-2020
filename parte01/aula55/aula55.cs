//Coleção Dictionary
using System;
using System.Collections.Generic;

class Aula55
{
    static void Main()
    {
        Dictionary<int, string> veiculos = new Dictionary<int, string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Motocicleta");
        veiculos.Add(15, "Patinete");

        //veiculos.Clear(); limpa o dicionário

        veiculos.Remove(20); //Removendo a chave 20

        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);

        int chave = 20;
        if (veiculos.ContainsKey(chave)) //Retorna true ou false
        {
            Console.WriteLine("A chave {0} está na coleção.", chave);
        }
        else
        {
            Console.WriteLine("A chave {0} não está na coleção.", chave);
        }

        string valor = "Navio";
        if (veiculos.ContainsValue(valor))
        {
            Console.WriteLine("O valor {0} está na coleção.", valor);
        }
        else
        {
            Console.WriteLine("O valor {0} não está na coleção.", valor);
        }

        veiculos[15] = "Bicicleta"; //Mudando valor da chave

        string valor2 = "Bicicleta";
        if (veiculos.ContainsValue(valor2))
        {
            Console.WriteLine("O valor {0} está na coleção.", valor2);
        }
        else
        {
            Console.WriteLine("O valor {0} não está na coleção.", valor2);
        }

        Console.WriteLine();
        foreach (KeyValuePair<int, string> v in veiculos)
        {
            Console.WriteLine(v.Value);
        }

        Console.WriteLine();
        foreach (KeyValuePair<int, string> v in veiculos)
        {
            Console.WriteLine(v.Key);
        }

        Console.WriteLine();
        Dictionary<int, string>.ValueCollection valores = veiculos.Values;
        foreach (string v in valores)
        {
            Console.WriteLine(v);
        }
    }
}