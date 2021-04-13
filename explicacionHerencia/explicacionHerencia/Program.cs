using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace explicacionHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            AlumnoUniversitario alumno = new AlumnoUniversitario("Hector", "Perez", 39107331, 1094959,"Programacion");
            Profesor profesor = new Profesor("Mauricio", "Davila", 39107331, "Programacion");

            personas.Add(alumno);
            personas.Add(profesor);

            foreach (Persona persona in personas)
            {
                if (persona is AlumnoUniversitario)
                {
                    AlumnoUniversitario alumnoAux = (AlumnoUniversitario)persona;
                    Console.WriteLine(alumnoAux.MostrarAlumnoUniversitario());
                }
                else
                {
                    Profesor profesorAux = (Profesor)persona;
                    Console.WriteLine(profesorAux.MostrarProfesor());
                }
            }

            // Console.WriteLine(alumno.MostrarAlumno());

            Console.ReadKey();
        }
    }
}
