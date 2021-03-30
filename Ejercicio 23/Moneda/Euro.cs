using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 1 / 1.10;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public static void SetCotizacion(double cotizacion)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Dolar)e);
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.cantidad + ((Dolar)p).GetCantidad());
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).GetCantidad());
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.cantidad - ((Dolar)p).GetCantidad());
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).GetCantidad());
        }

        public static bool operator ==(Euro s1, Euro s2)
        {
            return s1.cantidad == s2.cantidad;
        }

        public static bool operator !=(Euro s1, Euro s2)
        {
            return !(s1 == s2);
        }

        public static bool operator ==(Euro s1, Dolar s2)
        {
            return s1 == (Euro)s2;
        }

        public static bool operator !=(Euro s1, Dolar s2)
        {
            return !(s1 == s2);
        }

        public static bool operator ==(Euro s1, Pesos s2)
        {
            return s1 == (Euro)s2;
        }

        public static bool operator !=(Euro s1, Pesos s2)
        {
            return !(s1 == s2);
        }
    }
}
