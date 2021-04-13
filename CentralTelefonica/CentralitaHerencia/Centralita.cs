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
                            Local local = (Local)llamada;
                            valorRecaudado = valorRecaudado + local.CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Provincial)
                        {
                            Provincial provincial = (Provincial)llamada;
                            valorRecaudado = valorRecaudado + provincial.CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Local)
                        {
                            Local local = (Local)llamada;
                            valorRecaudado = valorRecaudado + local.CostoLlamada;
                        }
                        else if(llamada is Provincial)
                        {
                            Provincial provincial = (Provincial)llamada;
                            valorRecaudado = valorRecaudado + provincial.CostoLlamada;
                        }
                    }
                    break;
            }
            return valorRecaudado;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------DATOS DE LA EMPRESA------------------\n");
            sb.AppendLine($"Nombre de la empresa: {this.razonSocial}");
            sb.AppendLine($"Ganancia Total: {GananciasPorTotal} Pesos.");
            sb.AppendLine($"Ganancia por llamada local: {GananciasPorLocal} Pesos.");
            sb.AppendLine($"Ganancia por llamada provincial: {GananciasPorProvincial} Pesos.");
            sb.AppendLine("\n--------------------------LLAMADAS------------------------\n");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                sb.AppendLine(llamada.Mostrar());
                sb.AppendLine("----------------------------------------------------------\n");
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas() 
        {
            // Chequear
        }
    }
}
