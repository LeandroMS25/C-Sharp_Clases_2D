using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(110);
            Pesos pesos = new Pesos(5500);
            Euro euro = new Euro(100);
            /*
            Console.WriteLine(((Dolar)euro).GetCantidad());
            Console.WriteLine(Dolar.GetCotizacion());
            Console.WriteLine((euro + dolar).GetCantidad());
            Console.WriteLine((euro + pesos).GetCantidad());
            Console.WriteLine(Math.Round((euro - dolar).GetCantidad(),2));

            Pesos pesito;
            pesito = (Pesos)18.20;
            Console.WriteLine(pesito.GetCantidad());
            */

            
            Console.WriteLine($"Dolar: {dolar.GetCantidad()} "+$"Pesos dolarizados: {((Dolar)pesos).GetCantidad()}" +" "+(dolar == pesos));
            Console.WriteLine($"Pesos: {pesos.GetCantidad()} " + $"Dolar pesificado: {((Pesos)dolar).GetCantidad()}" + " " + (pesos == dolar));
            Console.WriteLine($"Euro: {euro.GetCantidad()} " + $"Peso eurizado: {((Euro)pesos).GetCantidad()}" + " " + (euro == pesos));
            Console.WriteLine($"Pesos: {pesos.GetCantidad()} " + $"Euro pesificado: {((Pesos)dolar).GetCantidad()}" + " " + (pesos == euro));
            Console.WriteLine($"Dolar: {dolar.GetCantidad()} " + $"Euro dolarizados: {((Dolar)euro).GetCantidad()}" + " " + (dolar == euro));
            Console.WriteLine($"Euro: {euro.GetCantidad()} " + $"Dolar eurizado: {((Euro)dolar).GetCantidad()}" + " " + (euro == dolar));
        }
    }
}
