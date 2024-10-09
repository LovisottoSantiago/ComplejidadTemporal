using System;
using System.Collections.Generic;

namespace EntregaGrafos {

    public class Program {
        public static void Main(string[] args) {
            // Crear el grafo
            Grafo<string> bosque = new Grafo<string>();

            // Crear vértices
            Vertice<string> casaCaperucita = new Vertice<string>("Casa de Caperucita");
            Vertice<string> claro1 = new Vertice<string>("Claro 1");
            Vertice<string> claro2 = new Vertice<string>("Claro 2");
            Vertice<string> claro3 = new Vertice<string>("Claro 3");
            Vertice<string> claro4 = new Vertice<string>("Claro 4");
            Vertice<string> claro5 = new Vertice<string>("Claro 5");
            Vertice<string> claro6 = new Vertice<string>("Claro 6");
            Vertice<string> casaAbuelita = new Vertice<string>("Casa de la Abuelita");

            // Agregar vértices al grafo
            bosque.agregarVertice(casaCaperucita);
            bosque.agregarVertice(claro1);
            bosque.agregarVertice(claro2);
            bosque.agregarVertice(claro3);
            bosque.agregarVertice(claro4);
            bosque.agregarVertice(claro5);
            bosque.agregarVertice(claro6);
            bosque.agregarVertice(casaAbuelita);

            // Conectar vértices con frutales (aristas)
            bosque.conectar(casaCaperucita, claro1, 10);
            bosque.conectar(casaCaperucita, claro2, 15);
            bosque.conectar(casaCaperucita, claro3, 20);
            bosque.conectar(casaCaperucita, claro4, 8);
            bosque.conectar(claro1, claro3, 5);
            bosque.conectar(claro2, claro4, 38);
            bosque.conectar(claro2, claro6, 30);
            bosque.conectar(claro3, claro5, 3);

            bosque.conectar(claro4, claro6, 45);

            bosque.conectar(claro5, claro3, 3);
            bosque.conectar(claro5, claro6, 7);
            bosque.conectar(claro5, casaAbuelita, 35);
            bosque.conectar(claro6, casaAbuelita, 15);

            EjercicioGrafos ejercicios = new EjercicioGrafos();
            int maxFrutales = 30;
            // Encontrar el recorrido seguro con más frutales
            List<string> camino = ejercicios.CamSec(casaCaperucita, casaAbuelita, maxFrutales);

            // Imprimir el camino
            Console.WriteLine("Camino con más frutales:");
            foreach (var vertice in camino) {
                Console.WriteLine(vertice);
            }

            Console.WriteLine("\nCamino nuevo, máximo 20 frutales: ");
            List<string> nuevoCamino = ejercicios.CamSec(casaCaperucita, casaAbuelita, 20);
            foreach (var vertice in nuevoCamino) {
                Console.WriteLine(vertice);
            }

            Console.ReadKey();
        }
    }
}