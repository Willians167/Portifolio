using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List<T>
        List<int> listaInteiro = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Lista<int>: " + string.Join(", ", listaInteiro));

        // SortedList<TKey, TValue>
        SortedList<string, int> listaStringInteiro = new SortedList<string, int>();
        listaStringInteiro.Add("b", 2);
        listaStringInteiro.Add("a", 1);
        listaStringInteiro.Add("c", 3);
        Console.WriteLine("SortedList<string, int>: " + string.Join(", ", listaStringInteiro));

        // Dictionary<TKey, TValue>
        Dictionary<string, int> dicionarioStringInteiro = new Dictionary<string, int>();
        dicionarioStringInteiro.Add("b", 2);
        dicionarioStringInteiro.Add("a", 1);
        dicionarioStringInteiro.Add("c", 3);
        Console.WriteLine("Dictionary<string, int>: " + string.Join(", ", dicionarioStringInteiro));

        // Queue<T>
        Queue<int> filaInteiro = new Queue<int>();
        filaInteiro.Enqueue(1);
        filaInteiro.Enqueue(2);
        filaInteiro.Enqueue(3);
        Console.WriteLine("Queue<int>: " + string.Join(", ", filaInteiro));

        // Stack<T>
        Stack<int> pilhaInteiro = new Stack<int>();
        pilhaInteiro.Push(1);
        pilhaInteiro.Push(2);
        pilhaInteiro.Push(3);
        Console.WriteLine("Stack<int>: " + string.Join(", ", pilhaInteiro));

        // LinkedList<T>
        LinkedList<int> listaLigadaInteiro = new LinkedList<int>();
        listaLigadaInteiro.AddLast(1);
        listaLigadaInteiro.AddLast(2);
        listaLigadaInteiro.AddLast(3);
        Console.WriteLine("LinkedList<int>: " + string.Join(", ", listaLigadaInteiro));

        // HashSet<T>
        HashSet<int> conjuntoInteiro = new HashSet<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("HashSet<int>: " + string.Join(", ", conjuntoInteiro));

        // SortedSet<T>
        SortedSet<int> conjuntoOrdenadoInteiro = new SortedSet<int> { 5, 3, 1, 4, 2 };
        Console.WriteLine("SortedSet<int>: " + string.Join(", ", conjuntoOrdenadoInteiro));
    }
}