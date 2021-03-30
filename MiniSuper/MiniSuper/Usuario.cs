using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper
{
    public class Usuario
    {
        string apellido;
        string nombre;
        long dni;
        string[] formasPago;
        string formaPago;
        string provincia;

        public Usuario(string apellido, string nombre, long dni, string[] formasPago, string formaPago, string provincia)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
            this.formasPago = formasPago;
            this.formaPago = formaPago;
            this.provincia = provincia;
        }
    }
}
