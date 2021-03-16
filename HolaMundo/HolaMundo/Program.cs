using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        /// <summary>
        /// Leyenda
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hola Mundo");
            int valorEntero = 32;

            Console.WriteLine("Ingrese un numero entero: ");
            string numeroString = Console.ReadLine();

            int suma = valorEntero + int.Parse(numeroString);

            float valorDecimal = 25.6f;
            double numeroDec = 25.35;

            int numeroEntero;

            // Casteo Explicito - Podría implicar pérdida de información y necesito usar el operador de casteo "(int), por ejemplo"
            numeroEntero = (int)valorDecimal;

            Console.WriteLine(valorDecimal);
            Console.WriteLine(valorEntero.ToString() + numeroString); // Concatena porque son 2 strings

            // Casteo Implicito - No debería implicar pérdida de información y no estoy obligado a usar el operador de casteo
            // Pasas de una variable de menor memoria a una de mayor memoria. Ejemplo: de int a float.
            valorDecimal = suma;

            valorDecimal.ToString();

            Console.WriteLine("Su numero es: "+suma);
            */

            Console.WriteLine("Ingrese un numero: ");
            string dato = Console.ReadLine();

            float valorFloat = float.Parse(dato.Replace(".",",")); // Replace - Metodo para reemplazar un String por otro.
            Console.WriteLine(QuitarParteEntera(valorFloat));
            Console.WriteLine(valorFloat);

            //Ctrl F5
            Console.ReadKey();
        }

        /// <summary>
        /// Quita la parte entera del numero recibido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static float QuitarParteEntera(float numero) 
        {
            // C# es de tipado estatico. Hay que declarar las variables con un tipo y éste no va a cambiar.
            int numeroEntero = (int)numero;
            return numero - numeroEntero;
        }
    }
}
