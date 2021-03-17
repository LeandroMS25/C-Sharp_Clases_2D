using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int numeroIngresado;
            int numeroMin = int.MaxValue;
            int numeroMax = int.MinValue;  
            float promedio;
            int total = 0;
            while (i < 3)
            {
                Console.Write("Ingrese un numero entre -100 y 100({0}): ", i + 1);
                numeroIngresado = int.Parse(Console.ReadLine());
                if (Validacion.Validar(numeroIngresado, -100, 100) == true)
                {
                    i++;
                    total = total + numeroIngresado;
                    if (i == 0 || numeroIngresado < numeroMin)
                    {
                        numeroMin = numeroIngresado;
                    }
                    if (i == 0 || numeroIngresado > numeroMax)
                    {
                        numeroMax = numeroIngresado;
                    }
                }
                else
                {
                    Console.WriteLine("El numero ingresado no está dentro de los valores.");
                }
            }
            promedio = (float)total / 3;
            Console.WriteLine("Numero maximo: {0} - Numero Minimo: {1} - Promedio {2}", numeroMax,numeroMin,promedio);
            Console.ReadKey();
        }
    }
}
