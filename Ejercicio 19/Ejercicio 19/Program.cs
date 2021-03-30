using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador suma = new Sumador();
            Sumador suma2 = new Sumador();
            int cantidadSuma;
            long sumaObjetos;
            bool cantSumas;

            Console.WriteLine(suma.Sumar("5","5"));
            Console.WriteLine(suma.Sumar(5, 5));
            Console.WriteLine(suma2.Sumar("6", "6"));
            Console.WriteLine(suma2.Sumar(6, 6));

            cantidadSuma = (int)suma;
            Console.WriteLine(cantidadSuma);

            sumaObjetos = suma + suma2;
            Console.WriteLine(sumaObjetos);
            cantSumas = suma | suma2;
            Console.WriteLine(cantSumas);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
