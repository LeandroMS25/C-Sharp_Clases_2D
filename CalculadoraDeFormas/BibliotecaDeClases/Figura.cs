using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public abstract class Figura
    {
        /*
        protected double superficie;
        protected double perimetro;

        protected Figura()
        {
            this.superficie = 0;
            this.perimetro = 0;
        }

        protected string Superficie
        {
            get
            {
                return this.superficie.ToString();
            }
            set 
            {
                this.superficie = double.Parse(value);
            }
        }

        protected string Perimetro
        {
            get
            {
                return this.perimetro.ToString();
            }
            set
            {
                this.perimetro = double.Parse(value);
            }
        }
        */
        public virtual string Dibujar() 
        {
            return "Dibujando un...";
        }

        public abstract double CalcularSuperficie();

        public abstract double CalcularPerimetro();
    }
}
