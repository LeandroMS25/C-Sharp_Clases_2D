using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Rectangulo:Figura
    {
        private double lado1;
        private double lado2;

        public Rectangulo(double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public override string Dibujar()
        {
            return base.Dibujar() + " Rectangulo";
        }

        public override double CalcularPerimetro()
        {
            return Math.Round(2 * (this.lado1 + this.lado2),2);
        }

        public override double CalcularSuperficie()
        {
            return Math.Round(this.lado1 * this.lado2,2);
        }
    }
}
