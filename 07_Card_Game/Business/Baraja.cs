using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Baraja
    {
        public Carta[] mazo = new Carta[48];

        public Baraja() 
        {
            for (int i = 0; i < 4; i++)
            {
                Carta newCarta;
                for (int j = 1; j <= 12; j++)
                {
                    newCarta = new Carta((Carta.Valor)j, (Carta.Palo)i);
                    mazo[(i * 12) + j - 1] = newCarta;
                }
            }
        }

        public static string MostrarBaraja(Baraja b) 
        {
            StringBuilder sb = new StringBuilder();

            foreach (Carta carta in b.mazo)
            {
                sb.AppendLine($"{carta.ObtenerNombre()}");
            }
            return sb.ToString();
        }

        private bool ValidarArrayConElementos(Baraja b) 
        {
            foreach (Carta carta in b.mazo)
            {
                if (carta is null) 
                {
                    return false;
                }
            }
            return true;
        }

        public static Carta RetornarUltimaCarta(Baraja b) 
        {
            Carta ultimaCarta = null;
            if (b.ValidarArrayConElementos(b))
            {
                ultimaCarta = b.mazo[b.mazo.Length - 1];
                Array.Resize(ref b.mazo, b.mazo.Length - 1);
            }
            return ultimaCarta;
        }

        public void AgregarCarta(Carta c)
        {
            if (mazo.Length < 48)
            {
                Array.Resize(ref mazo, mazo.Length + 1);
                mazo[mazo.Length - 1] = c;
            }
        }

        public Baraja MezclarBaraja(Baraja b) 
        {
            int az;
            Carta tmp;
            Random rdm = new Random();
            for (int i = b.mazo.Length -1; i > 1; i--)
            {
                az = rdm.Next(0,i);
                tmp = b.mazo[az];
                b.mazo[az] = b.mazo[i];
                b.mazo[i] = tmp;
            }
            return b;
        }
    }
}
