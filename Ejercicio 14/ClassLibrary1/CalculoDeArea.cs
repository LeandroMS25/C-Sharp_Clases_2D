using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class CalculoDeArea
    {
        /// <summary>
        /// Calcular el area de un cuadrado.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static double CalcularCuadrado(double valor)
        {
            return Math.Pow(valor, 2);            
        }
        /// <summary>
        /// Calcular el area de un triangulo.
        /// </summary>
        /// <param name="basee"></param>
        /// <param name="altura"></param>
        /// <returns></returns>
        public static double CalcularTriangulo(double basee ,double altura)
        {
            return (basee * altura)/(double)2;
        }
        /// <summary>
        /// Calcular el area de un circulo.
        /// </summary>
        /// <param name="radio"></param>
        /// <returns></returns>
        public static double CalcularCirculo(double radio)
        {
            return Math.Round(Math.PI*Math.Pow(radio,2),2);
        }
    }
}
