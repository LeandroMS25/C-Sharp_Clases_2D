using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Ingresa un numero: ");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    Console.WriteLine("El cuadrado del numero es: {0}", Math.Pow(num, 2));
                    Console.WriteLine("El cubo del numero es: {0}", Math.Pow(num, 3));
                }
                else 
                {
                    Console.WriteLine("!ERROR¡ Reingresar el numero.");
                }
            } while (num <= 0);
            Console.ReadKey();
        }
    }
}
