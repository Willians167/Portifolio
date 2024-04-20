using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<bool> listaBooleana = new List<bool> { true, false, true, false, true };

        // Adiciona um novo valor booleano à lista
        listaBooleana.Add(false);

        // Remove a primeira ocorrência de "true" da lista
        listaBooleana.Remove(true);

        // Remove o item no índice 2
        listaBooleana.RemoveAt(2);

        // Verifica se a lista contém "true"
        bool contemTrue = listaBooleana.Contains(true);

        // Obtém o índice de "false"
        int indiceDeFalse = listaBooleana.IndexOf(false);

        // Insere "true" no índice 1
        listaBooleana.Insert(1, true);

        // Imprime o número de elementos na lista
        Console.WriteLine("Número de elementos: " + listaBooleana.Count);

        // Limpa a lista
        listaBooleana.Clear();

        // Verifica se a lista está vazia
        bool listaVazia = listaBooleana.Count == 0;

        // Imprime se a lista está vazia
        Console.WriteLine("Lista vazia: " + listaVazia);
    }
}