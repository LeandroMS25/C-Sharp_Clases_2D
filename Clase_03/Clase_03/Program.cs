using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Leandro","Sobrino");
            string nombreCompleto = cliente1.ObtenerNombreCompleto();
            Console.WriteLine(nombreCompleto);
        }
    }
}
