using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Email:IMensaje
    {
        public string origen;
        public string destino;

        public Email(string origen, string destino)
        {
            this.origen = origen;
            this.destino = destino;
        }

        public string EnviarMensaje()
        {
            return "Hola mundo";
        }
    }
}
