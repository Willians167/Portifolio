using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> numeros = new List<string> { "Maria", "João", "Leila", "Caio", "Pedro" };

        // Adiciona uma nova string à lista
        numeros.Add("Ana");

        // Remove a primeira ocorrência de "Maria" da lista
        numeros.Remove("Maria");

        // Remove o item no índice 2
        numeros.RemoveAt(2);

        // Verifica se a lista contém "João"
        bool contemJoao = numeros.Contains("João");

        // Obtém o índice de "Caio"
        int indiceDeCaio = numeros.IndexOf("Caio");

        // Insere "Bruno" no índice 1
        numeros.Insert(1, "Bruno");

        // Imprime o número de elementos na lista
        Console.WriteLine("Número de elementos: " + numeros.Count);

        // Limpa a lista

        numeros.Clear();

        // Verifica se a lista está vazia
        bool listaVazia = numeros.Count == 0;

        // Imprime se a lista está vazia
        Console.WriteLine("Lista vazia: " + listaVazia);
    }
}