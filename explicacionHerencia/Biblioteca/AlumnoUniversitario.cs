using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AlumnoUniversitario:Alumno
    {
        private string carrera;

        public AlumnoUniversitario(string nombre, string apellido, long dni, int legajo, string carrera) : base(nombre, apellido, dni, legajo) 
        {
            this.carrera = carrera;
        }

        public string MostrarAlumnoUniversitario()
        {
            return string.Format(base.MostrarAlumno() + ", Carrera {0}", this.carrera);
        }
    }
}
