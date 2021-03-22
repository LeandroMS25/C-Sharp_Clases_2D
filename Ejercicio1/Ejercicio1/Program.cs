using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numIngresado;
            int max = int.MinValue;
            int min = int.MaxValue;
            int total = 0;
            float promedio;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                numIngresado = int.Parse(Console.ReadLine());
                if (numIngresado < min) 
                {
                    min = numIngresado;
                }
                else if (numIngresado > max)
                {
                    max = numIngresado;
                }
                total = total + numIngresado;
            }
            promedio = (float)total / 5;
            Console.WriteLine("Numero maximo: {0} - Numero minimo {1} - Promedio: {2}", max, min, promedio);
            Console.ReadKey();
        }
    }
}
