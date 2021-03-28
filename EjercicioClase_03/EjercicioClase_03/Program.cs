using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace EjercicioClase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Leandro","Sobrino","Roldan 940","42429218");
            Mascota mascota1 = new Mascota("Firulais","Perro", new DateTime(2010, 01, 01));
            cliente1.CambiarMascota(mascota1,0);
            Console.WriteLine(cliente1.Mostrar());
            Console.ReadKey();
        }
    }
}
