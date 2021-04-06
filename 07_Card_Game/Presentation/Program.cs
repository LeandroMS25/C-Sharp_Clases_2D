using Business;
using System;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Baraja barajaEspañola = new Baraja();
            Carta testCarta = new Carta((Carta.Valor)5,(Carta.Palo)2);
            Console.WriteLine(Baraja.MostrarBaraja(barajaEspañola));
            Carta ultimaCarta = Baraja.RetornarUltimaCarta(barajaEspañola);
            Console.WriteLine($"Ultima carta: {ultimaCarta.ObtenerNombre()}");
            barajaEspañola.AgregarCarta(testCarta);
            Console.WriteLine(Baraja.MostrarBaraja(barajaEspañola));
            barajaEspañola.MezclarBaraja(barajaEspañola);
            Console.WriteLine(Baraja.MostrarBaraja(barajaEspañola));
            Console.ReadKey();
        }
    }
}
