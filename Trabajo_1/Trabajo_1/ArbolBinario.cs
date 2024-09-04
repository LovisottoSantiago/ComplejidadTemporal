using System;
using System.Collections.Generic;

namespace Trabajo_1 {
    public class ArbolBinario<T> {
        private T dato; // Es el valor del Nodo.
        private ArbolBinario<T> hijoIzquierdo;
        private ArbolBinario<T> hijoDerecho;
        public ArbolBinario(T dato) {
            this.dato = dato;
        }

        //Getters  &&  Setters
        public T getDatoRaiz() {
            return this.dato;
        }
        public void setDatoRaiz(T datoRaiz) { // Se usa para el enunciado
            this.dato = datoRaiz;
        }

        public ArbolBinario<T> getHijoIzquierdo() {
            return this.hijoIzquierdo;
        }

        public ArbolBinario<T> getHijoDerecho() {
            return this.hijoDerecho;
        }

        // <-- Metodos -->
        public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
            this.hijoIzquierdo = hijo;
        }

        public void agregarHijoDerecho(ArbolBinario<T> hijo) {
            this.hijoDerecho = hijo;
        }

        public void eliminarHijoIzquierdo() {
            this.hijoIzquierdo = null;
        }

        public void eliminarHijoDerecho() {
            this.hijoDerecho = null;
        }

        public bool esHoja() {
            return this.hijoIzquierdo == null && this.hijoDerecho == null;
        }

        // <-- Metodos - Ejercicio 4 -->
        public bool incluye(T elemento) {
            if (this.dato.Equals(elemento)) {
                return true;
            }
            bool valorIzq = (this.hijoIzquierdo != null) && this.hijoIzquierdo.incluye(elemento); //Recursión
            bool valorDer = (this.hijoDerecho != null) && this.hijoDerecho.incluye(elemento); //Recursión
            return valorIzq || valorDer;  //True si al menos una de las condiciones es verdadera       
        }
        public void inorden() {
            if (this.hijoIzquierdo != null) {
                this.hijoIzquierdo.inorden(); //Recursión parte izq
            }
            Console.Write(this.dato + " ");
            if (this.hijoDerecho != null) {
                this.hijoDerecho.inorden();
            }
        }
        public void preorden() {
            Console.Write(this.dato + " ");
            if (this.hijoIzquierdo != null) {
                this.hijoIzquierdo.preorden();
            }
            if (this.hijoDerecho != null) {
                this.hijoDerecho.preorden();
            }
        }
        public void postorden() {
            if (this.hijoIzquierdo != null) {
                this.hijoIzquierdo.postorden();
            }
            if (this.hijoDerecho != null) {
                this.hijoDerecho.postorden();
            }
            Console.Write(this.dato + " ");
        }
        public int contarHojas() {
            // Si el nodo es una hoja, devuelve 1
            if (esHoja()) {
                return 1; // Hacemos uso del bool esHoja => NO TIENE HIJOS
            }

            // Contar las hojas lado izquierdo
            int hojasIzq = 0;
            if (this.hijoIzquierdo != null) {
                hojasIzq = this.hijoIzquierdo.contarHojas();
            }

            // Contar las hojas lado derecho
            int hojasDer = 0;
            if (this.hijoDerecho != null) {
                hojasDer = this.hijoDerecho.contarHojas();
            }

            // Sumar las hojas de ambos lados
            return hojasIzq + hojasDer;
        }
        public void recorridoEntreNiveles(int n, int m) {
            // Usar una lista para simular la cola
            List<(ArbolBinario<T>, int)> lista = new List<(ArbolBinario<T>, int)>();
            lista.Add((this, 0)); // Agregar el nodo raíz con nivel 0

            while (lista.Count > 0) {
                (ArbolBinario<T> nodo, int nivel) = lista[0]; // Obtener el primer elemento de la lista
                lista.RemoveAt(0); // Eliminar el primer elemento de la lista (simulando un desencolado)

                // Verificar que el nivel del nodo esté entre n y m
                if (nivel >= n && nivel <= m) {
                    Console.Write(nodo.dato + " ");
                }

                // Agregar los hijos a la lista con el nivel incrementado
                if (nodo.hijoIzquierdo != null) {
                    lista.Add((nodo.hijoIzquierdo, nivel + 1));
                }

                if (nodo.hijoDerecho != null) {
                    lista.Add((nodo.hijoDerecho, nivel + 1));
                }
            }
        }


        /* // < -- ENUNCIADO: PRACTICA 1 -- >
        - El método debe devolver un nuevo árbol, construído de la siguiente forma:
        - Si el árbol dado tiene hijo izquierdo, el nuevo árbol tendrá hijo izquierdo
          cuyo valor será  la suma del valor del  hijo izquierdo y el valor del padre 
          del árbol dado.
        - Si el árbol dado no tiene hijo izquierdo, tampoco lo tendrá el nuevo.
        - Los hijos derechos del nuevo árbol son iguales que los del árbol dado.
        - Las hojas del árbol dado serán hojas en el nuevo.
        */

        // < -- ENTREGABLE: PRACTICA 1 -- >
        public ArbolBinario<int> enunciadoNuevoArbol(ArbolBinario<int> arbol) {

            if (arbol == null) {
                throw new MiExcepcionPersonalizada("El parámetro ingresado está vacio");
            }

            // Crear un nuevo arbol con el dato del parámetro 'arbol' como raiz.
            ArbolBinario<int> nuevoArbol = new ArbolBinario<int>(arbol.getDatoRaiz());

            // Si el árbol dado tiene hijo izquierdo:
            if (arbol.getHijoIzquierdo() != null) {
                //Se crea un nuevo nodo (int) con la suma pedida por el enunciado:
                int nuevoValorIzquierdo = arbol.getDatoRaiz() + arbol.getHijoIzquierdo().getDatoRaiz(); // El dato del nodo izquierdo
                // Recursión para seguir recorriendo el subárbol:
                nuevoArbol.agregarHijoIzquierdo(enunciadoNuevoArbol(arbol.getHijoIzquierdo()));
                // Se hace uso del Set para establecer el valor del nuevo nodo al nuevo árbol:
                nuevoArbol.getHijoIzquierdo().setDatoRaiz(nuevoValorIzquierdo);
            }

            // Si el árbol dado tiene hijo derecho:
            if (arbol.getHijoDerecho() != null) {
                // Recursión para seguir recorriendo el subárbol, sin embargo, no cambia su valor.
                nuevoArbol.agregarHijoDerecho(enunciadoNuevoArbol(arbol.getHijoDerecho()));
            }

            return nuevoArbol;
        }

    }
}
