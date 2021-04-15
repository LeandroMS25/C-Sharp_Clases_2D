using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace Clase10_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vaca vaca = new Vaca("Vaquita");
            //Animal vaca2 = new Vaca("Vaca 2");
            //Console.WriteLine(vaca.Comer());
            //Console.WriteLine(vaca2.EmitirSonido());

            //Animal g1 = new Gato("Felix");
            //Gato gs1 = new GatoSiames("Bola de Nieve");
            //Console.WriteLine(gs1.EmitirSonido());
            //Console.WriteLine(g1.EmitirSonido());
            //Console.WriteLine(vaca.ResumenDeDatos());

            Vaca vaca = new Vaca("Vaquita");
            Animal vaca2 = new Vaca("Vaca 2");
            Console.WriteLine(vaca.ResumenDeDatos());
            Console.WriteLine(vaca2.ResumenDeDatos());
            Console.WriteLine(vaca.NoVirtual());
            Console.WriteLine(vaca2.NoVirtual());

            Console.ReadKey();
        }
    }
}
