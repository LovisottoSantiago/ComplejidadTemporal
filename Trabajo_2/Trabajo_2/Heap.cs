using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2 {

    public class Heap{

        private List<int> datos;
        private bool tipoHeap; // True si es Max, False si es Min
        private int tamaño;

        public Heap(int[] array, bool tipoHeap) {
            this.datos = new List<int>(array);
            this.tipoHeap = tipoHeap;
            this.tamaño = array.Length;
            buildHeap(); // El constructor inicializa la Heap
        }

        // <-- Ejercicio 2: Comienzo -- >
        public void intercambio(int i, int j) {
            int temp = datos[i];
            datos[i] = datos[j];
            datos[j] = temp;
        }

            public void heapify(int i) { //convertir una lista regular en una lista que cumple con las propiedades del heap.

                int padre = i;
                int hijoIzquierdo = 2 * i;
                int hijoDerecho = (2 * i) + 1;

                if (tipoHeap) { // true  caso base: hijoIzquierdo < tamaño
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
            int padre = tamaño / 2;

            if (tipoHeap) { // si es MaxHeap
                while (datos[tamaño] > datos[padre]) {
                    intercambio(tamaño, padre);
                    // Luego de hacer el intercambio
                    tamaño = padre; // tamaño ahora es la pos del elemento que acabo de intercambiar
                    padre = tamaño / 2; // recalculo la pos del padre
                }
            }
            else { // si es MinHeap
                while (datos[tamaño] < datos[padre]) {
                    intercambio(tamaño, padre);
                    tamaño = padre;
                    padre = tamaño / 2;
                }
            }
                return true;
            }

        public Heap eliminar() {
            int x = tope();
            datos.Remove(datos[0]);
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
