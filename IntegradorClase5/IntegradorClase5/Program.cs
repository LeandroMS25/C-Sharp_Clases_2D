using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace IntegradorClase5
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);

            Console.WriteLine(Producto.MostrarProducto(p1));
            Console.WriteLine(Producto.MostrarProducto(p2));
            Console.WriteLine(Producto.MostrarProducto(p3));
            Console.WriteLine(Producto.MostrarProducto(p4));
            Console.ReadKey();
        }
    }
}
