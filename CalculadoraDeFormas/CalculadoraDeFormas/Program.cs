using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formas;

namespace CalculadoraDeFormas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>()
            {
                new Rectangulo(6,4),
                new Circulo(5),
                new Cuadrado(5)
            };

            foreach (Figura figura in figuras)
            {
                Console.WriteLine("\n--------------- FIGURA {0:0#} ---------------\n", figuras.IndexOf(figura)+1);
                Console.WriteLine(figura.Dibujar());
                Console.WriteLine("Superficie: "+figura.CalcularSuperficie());
                Console.WriteLine("Perimetro: "+figura.CalcularPerimetro());
                Console.WriteLine("Tipo de la figura: "+figura.GetType());
                Console.WriteLine("\n-----------------------------------------\n");
            }
            Console.ReadKey();
        }
    }
}
