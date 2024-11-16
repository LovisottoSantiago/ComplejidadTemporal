using System;
using System.Collections.Generic;

namespace EntregaGrafos {

    public class EjercicioGrafos {

        public List<string> CamSec(Vertice<string> origen, Vertice<string> destino, int maxFrutales) {
            List<Vertice<string>> actual = new List<Vertice<string>>();
            List<string> mejorCamino = new List<string>();
            int costoMax = int.MinValue;

            CamSecRec(origen, destino, maxFrutales, actual, 0, mejorCamino, ref costoMax);

            return mejorCamino;
        }

        private void CamSecRec(Vertice<string> origen, Vertice<string> destino, int maxFrutales, List<Vertice<string>> actual, int costoActual, List<string> mejorCamino, ref int costoMax) {
            // Agregamos el vértice actual al camino
            actual.Add(origen);

            // Si llegamos al destino
            if (origen == (destino)) {
                // Si el costo acumulado es mayor que el costo máximo
                if (costoActual > costoMax) {
                    costoMax = costoActual;
                    mejorCamino.Clear();

                    // Agregamos el camino actual al mejor camino
                    foreach (var v in actual) {
                        mejorCamino.Add(v.getDato());
                    }
                }
            }
            else {
                // Exploramos los adyacentes de origen
                foreach (var arista in origen.getAdyacentes()) {
                    Vertice<string> destinoAdyacente = arista.getDestino();
                    int costoArista = arista.getPeso();

                    // Solo seguimos si el destino no fue visitado y el peso es menor o igual al maxFrutales
                    if (!actual.Contains(destinoAdyacente) && costoArista <= maxFrutales) {
                        CamSecRec(destinoAdyacente, destino, maxFrutales, actual, costoActual + costoArista, mejorCamino, ref costoMax);
                    }
                }
            }

            // Retrocedemos en el camino
            actual.RemoveAt(actual.Count - 1);
        }
    }
}
