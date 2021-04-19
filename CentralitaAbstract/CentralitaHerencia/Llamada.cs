using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
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

        public abstract float CostoLlamada 
        {
            get;
        }

        protected virtual string Mostrar()
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

        public static bool operator ==(Llamada l1, Llamada l2) 
        {
            if (l1.Equals(l2) && l1.nroDestino == l2.nroDestino
                && l1.nroOrigen == l2.nroOrigen)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
    }
}
