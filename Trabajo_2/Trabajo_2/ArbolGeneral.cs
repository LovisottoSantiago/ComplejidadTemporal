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




    }
}
