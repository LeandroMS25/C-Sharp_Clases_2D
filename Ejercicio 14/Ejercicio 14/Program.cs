using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double ladoCuadrado;
            double areaCuadrado;
            Console.Write("Ingrese la medida de uno de los lados del cuadrado: ");
            ladoCuadrado = double.Parse(Console.ReadLine());
            areaCuadrado = CalculoDeArea.CalcularCuadrado(ladoCuadrado);
            Console.Write("El area del cuadrado es de: {0} Cm2",areaCuadrado);
            */
            /*
            double baseTriangulo;
            double alturaTriangulo;
            double areaTriangulo;
            Console.Write("Ingrese la base del triangulo: ");
            baseTriangulo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del triangulo: ");
            alturaTriangulo = double.Parse(Console.ReadLine());
            areaTriangulo = CalculoDeArea.CalcularTriangulo(baseTriangulo,alturaTriangulo);
            Console.Write("El area del triangulo es de: {0} Cm2", areaTriangulo);
            */
            double radio;
            double areaCirculo;
            Console.Write("Ingrese el radio del circulo: ");
            radio = double.Parse(Console.ReadLine());
            areaCirculo = CalculoDeArea.CalcularCirculo(radio);
            Console.Write("El area del ciruclo es de: {0} Cm2", areaCirculo);
            Console.ReadKey();
        }
    }
}
