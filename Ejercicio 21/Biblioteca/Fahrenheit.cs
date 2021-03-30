using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Fahrenheit
    {
        private double temperatura;

        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTempatura()
        {
            return this.temperatura;
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.temperatura - 32) * 5/9);
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.temperatura - 32) * 5/9 + 273.15);
        }
    }
}
