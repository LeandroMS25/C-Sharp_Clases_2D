using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
   
namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alum1 = new Alumno("Leandro","Sobrino",1094959);
            alum1.Estudiar(10,8);
            alum1.CalcularFinal();
            Console.WriteLine(alum1.Mostrar());
            Console.ReadKey();
        }
    }
}
