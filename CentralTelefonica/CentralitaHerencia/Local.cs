using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        protected float costo;

        public Local(Llamada l, float costo) : base(l.GetDuracion, l.GetNroOrigen, l.GetNroDestino) 
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : this(new Llamada(duracion, destino, origen), costo) 
        {

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
            sb.AppendLine($"Costo de llamada local: {CostoLlamada}");
            return sb.ToString();
        }

        private float CalcularCosto() 
        {
            float costoLlamada = this.duracion * this.costo;
            return costoLlamada;
        }
    }
}
