using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        /// <summary>
        /// Constructor. Se llama igual que la clase.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Cliente(string nombre, string apellido) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public void CambiarNombre(string nombre) 
        {
            this.nombre = nombre;
        }

        public void CambiarApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string ObtenerNombreCompleto () 
        {
            // return nombre + " " + apellido;
            return $"{this.nombre} {this.apellido}";
        }
    }
}
