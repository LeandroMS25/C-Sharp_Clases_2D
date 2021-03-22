using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo Rojo = new Boligrafo(50,ConsoleColor.Red);
            Boligrafo Azul = new Boligrafo(100,ConsoleColor.Blue);
            Console.ReadKey();
        }
    }
}
