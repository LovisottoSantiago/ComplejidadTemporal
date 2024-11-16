using System;
class Program {
    public static void Main(String[] args){
        
        int[] prueba = new int[]{0, 8, 9, 34, 1, 3};
        Heap heap = new Heap();
        heap.maxHeapify(prueba, 5, 1);
        
        foreach (int x in prueba){
            Console.WriteLine(x);
            //! prueba
        }

        System.Console.WriteLine("\nPrueba");
         // Crear nodos
        Nodo raiz = new Nodo(10);
        raiz.izquierdo = new Nodo(5);
        raiz.derecho = new Nodo(12);
        raiz.izquierdo.izquierdo = new Nodo(3);
        raiz.izquierdo.derecho = new Nodo(8);
        raiz.derecho.izquierdo = new Nodo(6);
        raiz.derecho.derecho = new Nodo(14);

        // Crear el árbol
        Arbol arbol = new Arbol(raiz);

        // Llamar al método
        arbol.ImprimirParesEnNivelesImpares();
    }





}


