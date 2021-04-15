using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Vaca:Animal
    {
        protected int edad;
        public Vaca(string nombre, int edad) : base(nombre)
        {
            this.edad = edad;
        }

        protected override bool EsDomestico 
        {
            get 
            {
                return false;
            }
        }

        public override string EmitirSonido()
        {
            return "Muuuuu";
        }

        public string Comer() 
        {
            return "La vaca esta comiendo caca";
        }

        public override string ResumenDeDatos()
        {
            return "Soy una vaca";
        }

        public new string NoVirtual() 
        {
            return "Metodo no virtual de la clase Vaca";
        }
    }
}
