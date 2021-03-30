using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d) 
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        public static implicit operator Dolar(double d) 
        {
            return new Dolar(d);
        }

        public static Dolar operator +(Dolar d, Pesos p) 
        {
            return new Dolar(d.cantidad + ((Dolar)p).GetCantidad());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).GetCantidad());
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).GetCantidad());
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).GetCantidad());
        }

        public static bool operator ==(Dolar s1, Dolar s2)
        {
            return s1.cantidad == s2.cantidad;
        }

        public static bool operator !=(Dolar s1, Dolar s2)
        {
            return !(s1 == s2);
        }

        public static bool operator ==(Dolar s1, Pesos s2)
        {
            return s1 == (Dolar)s2;
        }

        public static bool operator !=(Dolar s1, Pesos s2)
        {
            return !(s1 == s2);
        }

        public static bool operator ==(Dolar s1, Euro s2)
        {
            return s1 == (Dolar)s2;
        }

        public static bool operator !=(Dolar s1, Euro s2)
        {
            return !(s1 == s2);
        }
    }
}
