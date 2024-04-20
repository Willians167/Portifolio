using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("A lista tem " + numeros.Count + " elementos.");
        Console.WriteLine("O primeiro elemento da lista é " + numeros[0] + ".");
        Console.WriteLine("O último elemento da lista é " + numeros[numeros.Count - 1] + ".");

        numeros.Add(6);
        numeros.RemoveAt(0);

        Console.WriteLine("Após adicionar um elemento e remover o primeiro, a lista tem " + numeros.Count + " elementos.");
        Console.WriteLine("O primeiro elemento da lista é " + numeros[0] + ".");
        Console.WriteLine("O último elemento da lista é " + numeros[numeros.Count - 1] + ".");

        if (numeros.Contains(3))
        {
            Console.WriteLine("O valor 3 está na lista.");
        }

        int posicao = numeros.IndexOf(4);
        Console.WriteLine("O valor 4 está na posição " + posicao + " da lista.");

        numeros.Reverse();
        Console.WriteLine("Após inverter a lista, o primeiro elemento é " + numeros[0] + ".");

        numeros.Sort();
        Console.WriteLine("Após ordenar a lista, o primeiro elemento é " + numeros[0] + ".");
    }
}