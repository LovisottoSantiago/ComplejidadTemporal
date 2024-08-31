using System;

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
	
		public int contarHojas() {
			return 0;
		}
		
		public void recorridoEntreNiveles(int n,int m) {
		}

	
	}
}
