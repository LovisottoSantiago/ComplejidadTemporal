using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaVirtual {
    public class MiExcepcionPersonalizada : Exception {
        public MiExcepcionPersonalizada(string mensaje) : base(mensaje) { 

        }
    }
}
