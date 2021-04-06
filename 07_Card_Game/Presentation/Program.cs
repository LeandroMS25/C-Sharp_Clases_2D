using Business;
using System;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Baraja barajaEspañola = new Baraja();
            Console.WriteLine(Baraja.MostrarBaraja(barajaEspañola));

            Console.ReadKey();
        }
    }
}
