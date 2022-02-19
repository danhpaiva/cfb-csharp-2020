//Coleção Queue (Fila)
using System;
using System.Collections.Generic;

class Aula59
{
    static void Main()
    {
        // string[] veiculosArray = { "Carro", "Moto", "Navio", "Avião" }; opção para passar como parâmetro na fila
        Queue<string> veiculosFila = new Queue<string>();

        veiculosFila.Enqueue("Carro"); //Add no final da fila
        veiculosFila.Enqueue("Moto");
        veiculosFila.Enqueue("Navio");
        veiculosFila.Enqueue("Avião");

        Console.WriteLine("Tamanho da fila: " + veiculosFila.Count);

        string veiculo = "Avião";

        if (veiculosFila.Contains(veiculo))
        {
            Console.WriteLine("Veículo {0} encontrado.", veiculo);
        }
        else
        {
            Console.WriteLine("Veículo não {0} encontrado.", veiculo);
        }

        // veiculosFila.Clear(); limpa elementos da fila
        // Console.WriteLine("Primeiro veículo: " + veiculosFila.Dequeue()); //Pega o primeiro elemento, retorna esse elemento e retira ele da fila
        // Console.WriteLine("Tamanho da fila após usar o Dequeue " + veiculosFila.Count);
        // Console.WriteLine("Primeiro veículo: " + veiculosFila.Peek());
        // Console.WriteLine("Tamanho da fila usando o Peek: " + veiculosFila.Count); //Pega o primeiro elemento da fila e o retorna

        foreach (string v in veiculosFila)
        {
            Console.WriteLine("Veículos " + v);
        }

        Console.WriteLine("Tamanho da fila: " + veiculosFila.Count);

        while (veiculosFila.Count > 0)
        {
            Console.WriteLine(veiculosFila.Dequeue());
        }

        Console.WriteLine("Tamanho da fila: " + veiculosFila.Count);
    }
}