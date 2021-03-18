using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            char operacion;
            char respuesta;
            double resultado;
            do
            {
                Console.Write("Ingrese el primer numero: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la operacion que quiere realizar (+ | - | / | *): ");
                operacion = char.Parse(Console.ReadLine());
                resultado = Calculadora.Calcular(num1, num2, operacion);
                Console.WriteLine("El resultado es: {0}",resultado);
                Console.WriteLine("¿Desea realizar otra operacion?");
                respuesta = char.Parse(Console.ReadLine());
            } while (Validacion.ValidaS_N(respuesta));
            Console.ReadKey();
        }
    }
}
