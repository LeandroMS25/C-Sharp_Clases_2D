using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre)
            : this() 
        {
            this.nombre = nombre;
        }

        public Cliente Cliente 
        {
            get 
            {
                return Cliente;
            }
            set
            {
                if(this.clientes + )
            }
        }

        public static bool operator +(Negocio n, Cliente c) 
        {
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c) 
                {
                    return false;
                }
            }
            return true;
        }


    }
}
