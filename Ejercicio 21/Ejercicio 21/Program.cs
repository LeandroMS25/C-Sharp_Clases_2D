using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius tempC = new Celsius(10);
            Fahrenheit tempF = new Fahrenheit(50);
            Kelvin tempK = new Kelvin(283.15);

            Console.WriteLine($"Celsius a Fahrenheit: {((Fahrenheit)tempC).GetTempatura()}");
            Console.WriteLine($"Celsius a Kelvin: {((Kelvin)tempC).GetTempatura()}");
            Console.WriteLine($"Kelvin a Fahrenheit: {((Fahrenheit)tempK).GetTempatura()}");
            Console.WriteLine($"Kelvin a Celsius: {((Celsius)tempK).GetTempatura()}");
            Console.WriteLine($"Fahrenheit a Celsius: {((Celsius)tempF).GetTempatura()}");
            Console.WriteLine($"Fahrenheit a Kelvin: {((Kelvin)tempF).GetTempatura()}");
        }
    }
}
