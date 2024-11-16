using System;
using System.Collections.Generic;

public class Arbol
{
    public Nodo raiz;

    public Arbol(Nodo raiz)
    {
        this.raiz = raiz;
    }

    //! MEMORIZAR ESTO
    public void ImprimirParesEnNivelesImpares()
    {
        if (raiz == null)
        {
            return;
        }

        // Cola para hacer el recorrido por niveles
        Queue<(Nodo, int)> cola = new Queue<(Nodo, int)>();
        cola.Enqueue((raiz, 0)); // Añadimos la raíz con el nivel 0

        while (cola.Count > 0)
        {
            var (nodo, nivel) = cola.Dequeue();

            if (nivel % 2 == 1 && nodo.valor % 2 == 0)
            {
                Console.WriteLine(nodo.valor);
            }

            // Añadimos los hijos a la cola con su respectivo nivel
            if (nodo.izquierdo != null)
            {
                cola.Enqueue((nodo.izquierdo, nivel + 1));
            }

            if (nodo.derecho != null)
            {
                cola.Enqueue((nodo.derecho, nivel + 1));
            }
        }
    }
}
