using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1 {
    internal class ProfundidadDeArbolBinario {

        private ArbolBinario<int> raiz;

        public ProfundidadDeArbolBinario(ArbolBinario<int> raiz) {
            this.raiz = raiz;
        }
        public int sumaElementosRTA(int profundidadObjetivo) {
            return sumaElementosProfundidad(raiz, profundidadObjetivo, 0);
        }

        public int sumaElementosProfundidad(ArbolBinario<int> nodo, int profundidadObjetivo, int profundidadActual) {

            if (nodo == null) {
                return 0;
            }

            if (profundidadActual == profundidadObjetivo) {
                return nodo.getDatoRaiz();
            }

            int sumaIzq = sumaElementosProfundidad(nodo.getHijoIzquierdo(), profundidadObjetivo, profundidadActual + 1);
            int sumaDer = sumaElementosProfundidad(nodo.getHijoDerecho(), profundidadObjetivo, profundidadActual + 1);

            return sumaIzq + sumaDer;

        }
    }
}
