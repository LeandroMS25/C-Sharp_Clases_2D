using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja franjaHoraria,Llamada l) : base(l.GetDuracion, l.GetNroOrigen, l.GetNroDestino)
        {
            this.franjaHoraria = franjaHoraria;
        }

        public Provincial(string origen, Franja franjaHoraria, float duracion, string destino) : this(franjaHoraria, new Llamada(duracion, destino, origen))
        {

        }

        public enum Franja 
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo de llamada provincial: {CostoLlamada}");
            return sb.ToString();
        }

        private float CalcularCosto() 
        {
            float costoLlamada = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costoLlamada = this.duracion * 0.99F;
                    break;
                case Franja.Franja_2:
                    costoLlamada = this.duracion * 1.25F;
                    break;
                case Franja.Franja_3:
                    costoLlamada = this.duracion * 0.66F;
                    break;
            }
            return costoLlamada;
        }
    }
}
