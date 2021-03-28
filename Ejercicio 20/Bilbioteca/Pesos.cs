using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos() 
        {
            cotizRespectoDolar = 50;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion)
            :this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p);
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad + ((Pesos)e).GetCantidad());
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad + ((Pesos)d).GetCantidad());
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad - ((Pesos)e).GetCantidad());
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad - ((Dolar)d).GetCantidad());
        }

        public static bool operator ==(Pesos s1, Pesos s2)
        {
            return s1.cantidad == s2.cantidad;
        }

        public static bool operator !=(Pesos s1, Pesos s2)
        {
            return !(s1 == s2);
        }

        public static bool operator ==(Pesos s1, Dolar s2)
        {
            return s1 == (Pesos)s2;
        }

        public static bool operator !=(Pesos s1, Dolar s2)
        {
            return !(s1 == s2);
        }

        public static bool operator ==(Pesos s1, Euro s2)
        {
            return s1 == (Pesos)s2;
        }

        public static bool operator !=(Pesos s1, Euro s2)
        {
            return !(s1 == s2);
        }
    }
}
