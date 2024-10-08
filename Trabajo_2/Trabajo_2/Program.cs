﻿using System;
using Trabajo_2;

public class Program {
    public static void Main(string[] args) {


        /* Pruebas para ver que todo funcione correctamente
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
        */

        /*
        // Ejemplo para resolver el entregable
        Console.WriteLine("Heap Binaria y Arbol General: ");
        Console.WriteLine("A partir de la siguiente MinHeap almacenada en el vector:");
        int[] arr2 = { 12, 15, 20, 16, 24, 23, 34, 18 };
        Heap minHeap2 = new Heap(arr2, false); // Min Heap
        minHeap2.ImprimirArbol();
        Console.WriteLine("Inserte las claves 14, 10 y 22");

        Console.WriteLine("\nDespués del método agregar: ");
        minHeap2.agregar(14);
        minHeap2.agregar(10);
        minHeap2.agregar(22);
        minHeap2.ImprimirArbol();
        */



        ArbolGeneral<string> raiz = new ArbolGeneral<string>("A");
        ArbolGeneral<string> nodoB = new ArbolGeneral<string>("B");
        ArbolGeneral<string> nodoC = new ArbolGeneral<string>("C");
        ArbolGeneral<string> nodoD = new ArbolGeneral<string>("D");
        ArbolGeneral<string> nodoE = new ArbolGeneral<string>("E");
        ArbolGeneral<string> nodoF = new ArbolGeneral<string>("F");
        ArbolGeneral<string> nodoG = new ArbolGeneral<string>("G");

        raiz.agregarHijo(nodoB);
        raiz.agregarHijo(nodoC);
        nodoB.agregarHijo(nodoD);
        nodoB.agregarHijo(nodoE);
        nodoC.agregarHijo(nodoF);
        nodoC.agregarHijo(nodoG);

        int a = raiz.altura();
        Console.WriteLine("La altura del árbol es: " + a);
        Console.WriteLine(" ");
        int nivel = raiz.nivel(nodoC.getDatoRaiz());
        Console.WriteLine("El n° de nodos hasta la raíz es de: " + nivel);


        Console.WriteLine("\nRecorrido por niveles: ");
        raiz.porNiveles();

        int x = raiz.ancho();
        Console.WriteLine("\nSu ancho es " + x);

        int caudal = raiz.calcularCaudal(1000);
        Console.WriteLine("\nEl caudal es: " + caudal);

        Console.ReadKey();


    }
}