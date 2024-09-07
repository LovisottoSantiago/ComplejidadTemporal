using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2 {

    public class Heap{

        private List<int> datos;
        private bool tipoHeap; // True si es MaxHeap, False si es MinHeap
        private int tamaño;

        public Heap(int[] array, bool tipoHeap) {
            this.datos = new List<int>(array);
            this.tipoHeap = tipoHeap;
            this.tamaño = datos.Count;
            buildHeap(); // El constructor inicializa la Heap
        }

        // <-- Ejercicio 2: Comienzo -- > Se tomará en cuenta que el indice será 1 (uno) en vez de 0 (cero).
        public void intercambio(int i, int j) {
            int temp = datos[i];
            datos[i] = datos[j];
            datos[j] = temp;
        }

            public void heapify(int i) { //convertir una lista regular en una lista que cumple con las propiedades del heap.

                int padre = i;
                int hijoIzquierdo = 2 * i; // indice 1
                int hijoDerecho = (2 * i) + 1;

                if (tipoHeap) {
                    // Max Heap
                    if (hijoIzquierdo < tamaño && datos[hijoIzquierdo] > datos[padre]) {
                        padre = hijoIzquierdo;
                    }

                    if (hijoDerecho < tamaño && datos[hijoDerecho] > datos[padre]) {
                        padre = hijoDerecho;
                    }
                }

                else {
                    // Min Heap
                    if (hijoIzquierdo < tamaño && datos[hijoIzquierdo] < datos[padre]) {
                        padre = hijoIzquierdo;
                    }

                    if (hijoDerecho < tamaño && datos[hijoDerecho] < datos[padre]) {
                        padre = hijoDerecho;
                    }
                }

            if (padre != i) {
                intercambio(i, padre);
                heapify(padre);
            }

        }

        public void ImprimirArbol() {
            foreach (int i in datos) {
                Console.Write(i + " ");
            }

        }

        public void buildHeap() {
            for (int i = tamaño / 2; i >= 0; i--) {
                heapify(i);
            }
        }

        public bool agregar(int elemento) {
            datos.Add(elemento); // Agrega el elemento al final de la lista
            int i = datos.Count; // Índice basado en 1 del nuevo elemento
            int padre = i / 2; // Índice del padre basado en 1

            if (tipoHeap) { // MaxHeap
                while (i > 1 && datos[i - 1] > datos[padre - 1]) {
                    intercambio(i - 1, padre - 1);
                    i = padre;
                    padre = i / 2;
                }
            }
            else { // MinHeap
                while (i > 1 && datos[i - 1] < datos[padre - 1]) {
                    intercambio(i - 1, padre - 1);
                    i = padre;
                    padre = i / 2;
                }
            }

            return true;
        }

        public Heap eliminar() {
            int x = tope();
            datos.Remove(datos[x]);
            tamaño--;   
            return this;
        }

        public int tope() {
            if (tamaño == 0) throw new InvalidOperationException("Heap vacío");
            return datos[0];
        }

        public bool esVacia() {
            return tamaño == 0;
        }

        // <-- Ejercicio 2: Fin -- >




    }
}
