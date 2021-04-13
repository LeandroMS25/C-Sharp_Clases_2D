using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float GetDuracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string GetNroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string GetNroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {this.duracion} minutos.");
            sb.AppendLine($"Numero de destino: {this.nroDestino}");
            sb.AppendLine($"Numero de origen: {this.nroOrigen}");
            return sb.ToString();
        }
        
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            else 
            {
                return -1;
            }
            
        }
        
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
