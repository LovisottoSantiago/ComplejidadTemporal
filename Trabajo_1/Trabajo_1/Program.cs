using System;
using System.Runtime.Versioning;
using System.Threading;
namespace Trabajo_1
{

	public class Program
	{
		public static void Main(String[] args){
			
	 		// Crear un árbol binario de ejemplo
	        ArbolBinario<int> raiz = new ArbolBinario<int>(1);
	        ArbolBinario<int> nodo2 = new ArbolBinario<int>(2);
	        ArbolBinario<int> nodo3 = new ArbolBinario<int>(3);
	        ArbolBinario<int> nodo4 = new ArbolBinario<int>(4);
	        ArbolBinario<int> nodo5 = new ArbolBinario<int>(5);
	
	        // Construir el árbol
	        raiz.agregarHijoIzquierdo(nodo2);
	        raiz.agregarHijoDerecho(nodo3);
	        nodo2.agregarHijoIzquierdo(nodo4);
	        nodo2.agregarHijoDerecho(nodo5);
	
	        // Probar el método incluye
	        Console.WriteLine("¿El árbol incluye al 3? " + raiz.incluye(3)); // True
	        Console.WriteLine("¿El árbol incluye al 6? " + raiz.incluye(6)); // False
	
	        // Imprimir recorridos
	        Console.WriteLine("\nRecorrido inorden:");
	        raiz.inorden();
	
	        Console.WriteLine("\nRecorrido preorden:");
	        raiz.preorden();
	
	        Console.WriteLine("\nRecorrido postorden:");
	        raiz.postorden();

			Console.WriteLine("\nCantidad de hojas:");
			int a = raiz.contarHojas();
			Console.WriteLine(a);

			Console.WriteLine("\nRecorrido entre niveles: ");
            raiz.recorridoEntreNiveles(0, 2);


            Console.ReadKey();
		}
	}
}