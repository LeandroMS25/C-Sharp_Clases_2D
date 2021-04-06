using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Baraja
    {
        Carta[] barajaEspañola = new Carta[48];

        public Baraja() 
        {
            for (int i = 0; i < 4; i++)
            {
                Carta newCarta;
                for (int j = 1; j <= 12; j++)
                {
                    newCarta = new Carta((Carta.Valor)j, (Carta.Palo)i);
                    barajaEspañola[(i * 12) + j - 1] = newCarta;
                }
            }
        }

        public static string MostrarBaraja(Baraja b) 
        {
            StringBuilder sb = new StringBuilder();

            foreach (Carta carta in b.barajaEspañola)
            {
                sb.AppendLine($"{carta.ObtenerNombre()}");
            }
            return sb.ToString();
        }
    }
}
