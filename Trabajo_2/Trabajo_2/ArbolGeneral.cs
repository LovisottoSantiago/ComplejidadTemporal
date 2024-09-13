using System;
using System.Collections.Generic;

namespace Trabajo_2 {
    public class ArbolGeneral<T> {

        private T dato;
        private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();

        public ArbolGeneral(T dato) {
            this.dato = dato;
        }

        public T getDatoRaiz() {
            return this.dato;
        }

        public List<ArbolGeneral<T>> getHijos() {
            return hijos;
        }

        public void agregarHijo(ArbolGeneral<T> hijo) {
            this.getHijos().Add(hijo);
        }

        public void eliminarHijo(ArbolGeneral<T> hijo) {
            this.getHijos().Remove(hijo);
        }

        public bool esHoja() {
            return this.getHijos().Count == 0;
        }

        public int altura() {
            if (this.esHoja()) {
                return 0;
            }
            int alturaMax = 0;
            foreach (ArbolGeneral<T> hijo in this.getHijos()) {
                int longitud = hijo.altura();
                alturaMax = longitud;

            }
            return 1 + alturaMax;

        }

        public void recorrerPreorden() {
            Console.Write(this.getDatoRaiz() + " ");

            foreach (ArbolGeneral<T> hijo in this.getHijos()) {
                hijo.recorrerPreorden();
            }
        }


        public int nivel(T datoNodo) { // el nivel de un nodo es su distancia hasta la raíz

            if (this.dato != null && this.dato.Equals(datoNodo)) {
                return 0;
            }
    
            foreach (ArbolGeneral<T> hijo in this.getHijos()) {
                int nivelNodo = hijo.nivel(datoNodo);
                if (nivelNodo >= 0) {
                    return 1 + nivelNodo;                    
                }
            }
            return 0;
        }

        public void mostrarArbol() {
            Console.Write(this.getDatoRaiz() + " ");

            foreach (ArbolGeneral<T> dato in hijos) {
                dato.mostrarArbol();
            }
        }


        public void porNiveles() {
            Queue<ArbolGeneral<T>> cola = new Queue<ArbolGeneral<T>>() { };
            ArbolGeneral<T> arbolAuxiliar;

            cola.Enqueue(this); // estoy encolando el árbol entero

            while (cola.Count != 0) {
                arbolAuxiliar = cola.Dequeue();                
                Console.Write(arbolAuxiliar.getDatoRaiz() + " ");

                foreach (var hijo in arbolAuxiliar.getHijos()) {
                    cola.Enqueue(hijo);
                }
            }
        }


        public int ancho() {
            Queue<ArbolGeneral<T>> cola = new Queue<ArbolGeneral<T>>() { };
            ArbolGeneral<T> arbolAuxiliar;

            int ancho = 0; // Lleva la cuenta del ancho máximo encontrado
            int contador = 0; // Cuenta los árboles en el nivel actual

            cola.Enqueue(this); // Encolamos el árbol entero (la raíz)
            cola.Enqueue(null); // Encolamos el separador de nivel

            while (cola.Count != 0) {
                arbolAuxiliar = cola.Dequeue(); // Desencolamos el primer elemento

                // Si encontramos el separador (fin del nivel actual)
                if (arbolAuxiliar == null) {
                    if (contador > ancho) {
                        ancho = contador;
                    }
                    contador = 0; // Reiniciamos el contador para el siguiente nivel

                    // Si hay más nodos en la cola, encolamos otro separador
                    if (cola.Count != 0) {
                        cola.Enqueue(null);
                    }
                }
                // Si es un nodo del árbol
                else {
                    contador++; // Incrementamos el contador del nivel actual

                    // Encolamos los hijos del nodo actual
                    foreach (var hijo in arbolAuxiliar.getHijos()) {
                        cola.Enqueue(hijo);
                    }
                }
            }

            return ancho;
        }


        public int calcularCaudal(int caudal) {
            
            if (this.esHoja()) {
                return caudal;
            }
            int caudalMinimo = caudal;
            foreach(var hijo in this.getHijos()) {
                int caudalIndividual = caudal / getHijos().Count();

                int caudalHijo = hijo.calcularCaudal(caudalIndividual);

                if (caudalHijo < caudalMinimo) {
                    caudalMinimo = caudalHijo;                
                }

            }

            return caudalMinimo;
        }



    }
}
