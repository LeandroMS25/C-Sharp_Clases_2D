using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Kelvin
    {
        private double temperatura;

        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTempatura()
        {
            return this.temperatura;
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k.temperatura - 273.15) * 9/5 + 32);
        }

        public static explicit operator Celsius(Kelvin k)
        {
            return (Celsius)((Fahrenheit)k);
        }
    }
}
