using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public sealed class Cuadrado:Rectangulo
    {
        public Cuadrado(double lado):base(lado,lado)
        {
            
        }

        public override string Dibujar()
        {
            return base.Dibujar() + " Cuadrado";
        }
    }
}
