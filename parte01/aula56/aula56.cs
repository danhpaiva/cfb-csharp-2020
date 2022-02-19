//Coleção LinkedList duplamente encadeada
using System;
using System.Collections.Generic;

class Aula56
{
    static void Main()
    {
        LinkedList<string> transporte = new LinkedList<string>();

        transporte.AddFirst("Carro"); //Add no início da lista
        transporte.AddFirst("Avião");
        transporte.AddFirst("Navio");
        transporte.AddFirst("Motocicleta");

        transporte.AddLast("Bicicleta"); //Add no final da lista

        LinkedListNode<string> noDalista;

        noDalista = transporte.FindLast("Navio"); //Encontrar a posição do Navio
        transporte.AddAfter(noDalista, "Patinete"); //Adiciona após

        noDalista = transporte.FindLast("Navio"); //Encontrar a posição do Navio
        transporte.AddBefore(noDalista, "Patins"); //Adiciona antes

        noDalista = transporte.FindLast("Navio").Next; //Encontrar a proxima posição
        transporte.AddBefore(noDalista, "Nave Espacial"); //Adiciona antes

        noDalista = transporte.FindLast("Navio").Previous; //Encontrar a antecessora posição
        transporte.AddBefore(noDalista, "Nave de Guerra"); //Adiciona antes
        //transporte.Clear(); Limpa todos os elementos da lista

        if (transporte.Find("Carro") == null)
        {
            Console.WriteLine("Elemento não encontrado.");
        }
        else
        {
            Console.WriteLine("Elemento encontrado.");
        }

        // transporte.Remove("Navio"); Removendo
        // transporte.RemoveFirst();
        // transporte.RemoveLast();

        foreach (string t in transporte)
        {
            Console.WriteLine("Transporte: {0}", t);
        }


    }
}