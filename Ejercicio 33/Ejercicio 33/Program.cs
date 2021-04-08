using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotica;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            for (int i = 0; i < 5; i++)
            {
                libro[i] = String.Format("{0:0#}", i);
            }

            libro[6] = "La puta madre";

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Indice: {i} Pagina: {libro[i]}");
            }

            Console.ReadKey();
        }
    }
}
