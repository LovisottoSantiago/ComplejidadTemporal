using EntregaVirtual;
using System;
using System.Runtime.Versioning;
using System.Threading;

public class Program{
    public static void Main(String[] args){

        // Creo el árbol binario del ejemplo                
        ArbolBinario<int> raiz = new ArbolBinario<int>(1);  //       1
        ArbolBinario<int> nodo2 = new ArbolBinario<int>(2); //      / \
        ArbolBinario<int> nodo3 = new ArbolBinario<int>(3); //     2   3
        ArbolBinario<int> nodo4 = new ArbolBinario<int>(4); //    /   / \
        ArbolBinario<int> nodo5 = new ArbolBinario<int>(5); //   4   5   6
        ArbolBinario<int> nodo6 = new ArbolBinario<int>(6); //      /
        ArbolBinario<int> nodo7 = new ArbolBinario<int>(7); //     7

        // Construir el árbol
        raiz.agregarHijoIzquierdo(nodo2);
        raiz.agregarHijoDerecho(nodo3);
        nodo2.agregarHijoIzquierdo(nodo4);
        nodo3.agregarHijoIzquierdo(nodo5);
        nodo3.agregarHijoDerecho(nodo6);
        nodo5.agregarHijoIzquierdo(nodo7);

        Console.Write("\nArbol normal, recorrido entre niveles: ");
        raiz.recorridoEntreNiveles(0, 3); // Recorrido: 1 - 2 - 3 - 4 - 5 - 6 - 7
        Console.Write("\nArbol normal, recorrido preorden: ");
        raiz.preorden(); // Recorrido: 1 - 2 - 4 - 3 - 5 - 7 - 6

        try {
            ArbolBinario<int> nuevoArbol = raiz.enunciadoNuevoArbol(raiz); // Creo el árbol nuevo.

            Console.Write("\nArbol nuevo, recorrido entre niveles: ");
            nuevoArbol.recorridoEntreNiveles(0, 3);  // Recorrido: 1 - 3 - 3 - 6 - 8 - 6 - 12

            Console.Write("\nArbol nuevo, recorrido preorden: ");
            nuevoArbol.preorden(); // Recorrido: 1 - 3 - 6 - 3 - 8 - 12 - 6

            // El nuevo árbol debe verse de esta forma

            //       1
            //      / \
            //     3   3
            //    /   / \
            //   6   8   6
            //      /
            //     12

        }
        catch (MiExcepcionPersonalizada ex) {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.ReadKey();
    }





}