using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Celsius
    {
        private double temperatura;

        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTempatura()
        {
            return this.temperatura;
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit((c.temperatura * 9/5) + 32);
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return (Kelvin)((Fahrenheit)c);
        }
    }
}
