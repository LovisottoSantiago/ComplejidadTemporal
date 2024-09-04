using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2 {


    public class Heap{

        private int[] datos; 
        private bool tipoHeap; // True si es Max, False si es Min
        private int tamaño;

        public Heap(int[] datos, bool tipoHeap) {
            this.datos = datos;
            this.tipoHeap = tipoHeap;
            this.tamaño = datos.Length;
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

        public bool agregar() {
            return false;
        }

        public Heap eliminar() {
            return this;
        }

        public Heap tope() {
            return this;
        }

        public bool esVacia() {
            return datos.Count() == 0;
        }




        // <-- Ejercicio 2: Fin -- >




    }
}
