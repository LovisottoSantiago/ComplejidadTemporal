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

        Console.WriteLine("\n\nCreando Min Heap:");
        Heap minHeap = new Heap(arr, false); // Min Heap
        minHeap.ImprimirArbol();

        bool boolTest = maxHeap.esVacia();
        Console.WriteLine("\n\nLa lista, ¿está vacia?: " + boolTest);

        Console.WriteLine("\nPrueba del metodo agregar, después de agregar 14, el maxHeap queda así: ");        
        maxHeap.agregar(14);
        maxHeap.ImprimirArbol(); // Verifico que funciona dibujando el arbol a mano, 14 deberia quedar en la posicion 3


        Console.WriteLine("\nPrueba del metodo agregar, después de agregar 11, el minHeap queda así: ");
        minHeap.agregar(11);
        minHeap.ImprimirArbol(); // Verifico que funciona dibujando el arbol a mano, 11 deberia quedar en la posicion 6

        Console.WriteLine("\nPrueba del metodo eliminar con MaxHeap: ");
        maxHeap.eliminar();
        maxHeap.ImprimirArbol();

        Console.ReadKey();
    }
}