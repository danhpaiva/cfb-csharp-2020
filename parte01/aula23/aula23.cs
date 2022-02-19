//Métodos para Arrays
using System;

class Aula23
{
    static void Main()
    {

        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];

        int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };

        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = random.Next(10);
        }

        Console.WriteLine("Elementos do vetor1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine();

        //public static int BynarySearch(array, valor); retorno -1 (negativo) indica que o elemento não foi encontrado
        Console.WriteLine("BinarySearch");
        int procurado = 3;
        int posicao = Array.BinarySearch(vetor1, procurado);
        Console.WriteLine("Valor {0} está na posição {1}", procurado, posicao);
        Console.WriteLine("");

        //pubic static void Copy(AR_origem, Ar_destino, qtde_elementos);
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine();

        //public void CopyTo(Ar_destino, a_partir_desta_posicao);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine();

        //public long GetLongLenght(dimensão);
        Console.WriteLine("GetLongLenght");
        long qtdeElementosVetor = vetor1.GetLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        Console.WriteLine();

        //public long GetLowerBound(dimensão);
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D0 = matriz.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor índice do vetor1: {0}", MenorIndiceVetor);
        Console.WriteLine("Menor índice da matriz na dimensão 0: {0}", MenorIndiceMatriz_D0);
        Console.WriteLine("Menor índice da matriz na dimensão 1: {0}", MenorIndiceMatriz_D1);
        Console.WriteLine();

        //public long GetUpperBound(dimensão);
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D0 = matriz.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice do vetor1: {0}", MaiorIndiceVetor);
        Console.WriteLine("Maior índice da matriz na dimensão 0: {0}", MaiorIndiceMatriz_D0);
        Console.WriteLine("Maior índice da matriz na dimensão 1: {0}", MaiorIndiceMatriz_D1);
        Console.WriteLine();

        //public object GetValue(long índice);
        Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("Valor da posição (1,3) da matriz: {0}", valor1);
        Console.WriteLine();

        //public static int IndexOf(array, valor);
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
        Console.WriteLine();

        //public static int LastIndexOf(array, valor);
        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine("Indice do último valor 3: {0}", indice2);
        Console.WriteLine();

        //public static void Reverse(array);
        Console.WriteLine("Reverse Array");
        Array.Reverse(vetor1);
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine();

        //public void SetValue(object valor, long pos);
        Console.WriteLine("SetValue");
        vetor2.SetValue(99, 0);
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }
        Console.WriteLine("Vetor 2: ");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine();

        //public static void Sort(array);
        Array.Sort(vetor1); //Ordenar em ordem crescente
        Array.Sort(vetor2);
        Array.Sort(vetor3);

        Console.WriteLine("Vetor1:");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("\nVetor2:");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("\nVetor3:");
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
    }
}