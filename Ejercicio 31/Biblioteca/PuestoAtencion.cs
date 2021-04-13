using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        private PuestoAtencion() 
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) 
            : this()
        {
            this.puesto = puesto;
        }

        public enum Puesto 
        {
            Caja1,
            Caja2
        }

        public static int NumeroActual 
        {
            get 
            {
                return ++PuestoAtencion.numeroActual;
            }
        }

        public bool Atender(Cliente cli) 
        {
            return true;
        }
    }
}
