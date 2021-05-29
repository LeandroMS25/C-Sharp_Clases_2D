using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public sealed class Circulo:Figura
    {
        private const double PI = Math.PI;
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return base.Dibujar() + " Circulo";
        }

        public override double CalcularPerimetro()
        {
            return Math.Round(2*PI*this.radio, 2);
        }

        public override double CalcularSuperficie()
        {
            return Math.Round(PI*Math.Pow(this.radio, 2), 2);
        }
    }
}
