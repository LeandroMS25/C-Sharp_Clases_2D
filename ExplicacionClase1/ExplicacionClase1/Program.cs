using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicacionClase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine();
            Console.WriteLine("Ingrese una letra: ");
            char letra = Console.ReadKey().KeyChar;
            /*
            Program miPrograma = new Program();
            miPrograma.ContarLetras();
            */
            int cantidad = ContarLetras(palabra, letra);
            Console.WriteLine("\n La cantidad de letras es {0}", cantidad); // \n Salto de linea

            Console.ReadKey();
        }
        /// <summary>
        /// Cuenta la cantidad de letras que tiene la palabra que se recibe.
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="letra"></param>
        /// <returns></returns>
        static int ContarLetras(String texto, char letra)
        {
            int cantidad = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto.ToCharArray()[i] == letra)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        static int ContarLetras2(String texto, char letra)
        {
            int cantidad = 0;
            foreach (char item in texto.ToCharArray()) // item - recorre el array y guarda la posición en la que se encuentra
            {
                if (Char.ToLower(item) == Char.ToLower(letra))
                {
                    cantidad++;
                }
            }
            /*
            for (int i = 0; i < texto.Length; i++)
            {
                if (Char.ToLower(texto.ToCharArray()[i]) == Char.ToLower(letra))
                {
                    cantidad++;
                }
            }
            */
            return cantidad;
        }

        static int ContarLetras3(String texto, char letra)
        {
            int cantidad = 0;
            int i = 0;

            while (i < texto.Length)
            {
                if (Char.ToLower(texto[i]) == Char.ToLower(letra))
                {
                    cantidad++;
                }
                i++;
            }
            return cantidad;
        }
    }
}
