using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2 {


    public class Heap<T> {

        private T[] datos;
        private bool queHeapEs; // True si es Max, False si es Min

        public Heap(T[] datos, bool queHeapEs) {
            this.datos = datos;
            this.queHeapEs = queHeapEs;        
        }

        public T[] getDatos() { return datos; } 
        public bool getQueHeapEs() { return queHeapEs; }

        public bool esVacia() {
            return getDatos().Length == 0;
        }



    }
}
