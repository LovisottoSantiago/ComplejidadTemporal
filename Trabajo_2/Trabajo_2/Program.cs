using System;
using Trabajo_2;

public class Program {
    public static void Main(string[] args) {

        Console.WriteLine("Ejemplo de lista: ");
        int[] arr = { 1, 3, 5, 4, 6, 13, 10, 9, 8, 15, 17 };

        foreach (int i in arr) {
            Console.Write(i + " ");
        }

        // Crear instancia de Heap
        Console.WriteLine("\n\nCreando Max Heap:");
        Heap maxHeap = new Heap(arr, true); // Max Heap

        maxHeap.ImprimirArbol();

        Console.ReadKey();
    }
}