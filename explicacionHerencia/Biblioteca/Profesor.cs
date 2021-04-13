using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Profesor:Persona
    {
        private string catedra;

        public Profesor(string nombre, string apellido, long dni, string catedra) : base(nombre, apellido, dni) 
        {
            this.catedra = catedra;
        }

        public string Corregir()
        {
            return "Corrigiendo";
        }

        public string MostrarProfesor()
        {
            return string.Format(base.MostrarPersona() + ", Catedra {0}", this.catedra);
        }
    }
}
