using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1 {
    internal class RedBinariaLlena {

        private ArbolBinario<int> raiz;

        public RedBinariaLlena(ArbolBinario<int> raiz) {
            this.raiz = raiz;
        }

        public int calcularRetardoReenvio() {
            return retardoReenvio(this.raiz);
        }

        public int retardoReenvio(ArbolBinario<int> nodo) {
            if (nodo == null) {
                return 0;
            }

            int retardoActual = nodo.getDatoRaiz();

            // Si es una hoja, retorna su propio retardo
            if (nodo.esHoja()) {
                return retardoActual;
            }

            // Calcular el retardo máximo en los subárboles izquierdo y derecho
            int retardoIzquierdo = 0;
            int retardoDerecho = 0;

            if (nodo.getHijoIzquierdo() != null) {
                retardoIzquierdo = retardoReenvio(nodo.getHijoIzquierdo());
            }

            if (nodo.getHijoDerecho() != null) {
                retardoDerecho = retardoReenvio(nodo.getHijoDerecho());
            }

            // El retardo máximo es el mayor entre los dos subárboles, más el retardo del nodo actual
            return retardoActual + Math.Max(retardoIzquierdo, retardoDerecho);
        }

    }
}
