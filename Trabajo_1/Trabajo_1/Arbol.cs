using System;
using System.Collections.Generic;

namespace Trabajo_1
{
	public class ArbolBinario<T>
	{
		
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
	
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
		
		//Getters	
		public T getDatoRaiz() {
			return this.dato;
		}

		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
		
		//Metodos
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		
		//Metodos enunciado punto 4
		public bool incluye(T elemento) {
			if (this.dato.Equals(elemento)) {
                return true;
            }
            bool valorIzq = (this.hijoIzquierdo != null) && this.hijoIzquierdo.incluye(elemento); //Recursion
            bool valorDer = (this.hijoDerecho != null) && this.hijoDerecho.incluye(elemento); //Recursion
            return valorIzq || valorDer;  //True si al menos una de las condiciones es verdadera       
		}
	
		public void inorden() {
			if (this.hijoIzquierdo != null) {
                this.hijoIzquierdo.inorden(); //Recursion parte izq
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
	

		//Hacemos uso del bool esHoja => NO TIENE HIJOS
		public int contarHojas() {
		 // Si el nodo es una hoja, devuelve 1
		    if (esHoja()) {
		        return 1;
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


        public void recorridoEntreNiveles(int n, int m){
            // Usar una lista para simular la cola
            List<(ArbolBinario<T>, int)> lista = new List<(ArbolBinario<T>, int)>();
            lista.Add((this, 0)); // Agregar el nodo raíz con nivel 0

            while (lista.Count > 0)
            {
                (ArbolBinario<T> nodo, int nivel) = lista[0]; // Obtener el primer elemento de la lista
                lista.RemoveAt(0); // Eliminar el primer elemento de la lista (simulando un desencolado)

                // Verificar que el nivel del nodo esté entre n y m
                if (nivel >= n && nivel <= m)
                {
                    Console.Write(nodo.dato + " ");
                }

                // Agregar los hijos a la lista con el nivel incrementado
                if (nodo.hijoIzquierdo != null)
                {
                    lista.Add((nodo.hijoIzquierdo, nivel + 1));
                }

                if (nodo.hijoDerecho != null)
                {
                    lista.Add((nodo.hijoDerecho, nivel + 1));
                }
            }
        }



    }
}
