using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string razonSocial)
            : this()
        {
            this.razonSocial = razonSocial;
        }

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private void AgregarLlamada(Llamada l1) 
        {
            this.listaDeLlamadas.Add(l1);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float valorRecaudado = 0;
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Local)
                        {
                            valorRecaudado += ((Local)llamada).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Provincial)
                        {
                            valorRecaudado += ((Provincial)llamada).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Local)
                        {
                            valorRecaudado += ((Local)llamada).CostoLlamada;
                        }
                        else if (llamada is Provincial)
                        {
                            valorRecaudado += ((Provincial)llamada).CostoLlamada;
                        }
                    }
                    break;
            }
            return valorRecaudado;
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------DATOS DE LA EMPRESA------------------\n");
            sb.AppendLine($"Nombre de la empresa: {this.razonSocial}");
            sb.AppendLine($"Ganancia Total: {this.GananciasPorTotal} Pesos.");
            sb.AppendLine($"Ganancia por llamada local: {this.GananciasPorLocal} Pesos.");
            sb.AppendLine($"Ganancia por llamada provincial: {this.GananciasPorProvincial} Pesos.");
            sb.AppendLine("\n--------------------------LLAMADAS------------------------\n");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                sb.AppendLine(llamada.ToString());
                sb.AppendLine("----------------------------------------------------------\n");
            }
            return sb.ToString();
        }

        public override string ToString() 
        {
            return this.Mostrar();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public static bool operator ==(Centralita c, Llamada l) 
        {
            foreach (Llamada llamada in c.listaDeLlamadas)
            {
                if (llamada == l) 
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada l) 
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
                return c;
            }
            return c;
        }
    }
}
