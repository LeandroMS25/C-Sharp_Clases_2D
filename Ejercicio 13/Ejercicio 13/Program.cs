using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string binario;
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            binario = Conversor.DecimalBinario(numero);
            Console.Write("El numero binario es: {0}",binario);
        }
    }
}
