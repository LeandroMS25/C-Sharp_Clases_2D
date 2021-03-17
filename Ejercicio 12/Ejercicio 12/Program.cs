using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int sumaEnteros = 0;
            char respuesta;
            do
            {
                Console.Write("Ingrese un numero: ");
                numeroIngresado = int.Parse(Console.ReadLine());
                sumaEnteros = sumaEnteros + numeroIngresado;
                Console.Write("¿Desea continuar?");
                respuesta = Char.Parse(Console.ReadLine());
                Console.Clear();
            } while (ValidarRespuesta.ValidaS_N(respuesta));             
        }
    }
}
