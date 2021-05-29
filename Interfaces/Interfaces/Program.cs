using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMensaje> mensajes = new List<IMensaje>();

            Paloma paloma = new Paloma("Azir","Shurima");
            Courier courier = new Courier("Leandro","Sobrino","42429218");
            Carta carta = new Carta("A4", 1, "Lobo");
            Email mail = new Email("jefe@gmail.com", "programador@gmail.com");

            mensajes.Add(paloma);
            mensajes.Add(courier);
            mensajes.Add(carta);
            mensajes.Add(mail);

            foreach (IMensaje item in mensajes)
            {
                Console.WriteLine(item.EnviarMensaje());
            }

            Console.ReadKey();
        }
    }
}
