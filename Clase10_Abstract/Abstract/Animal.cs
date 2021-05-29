using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Animal
    {
        protected string nombre;

        protected Animal(string nombre)
        {
            this.nombre = nombre;
        }

        protected string Nombre
        {
            get 
            {
                return this.nombre;
            }
        }

        protected abstract bool EsDomestico 
        {
            get;
        }

        public abstract string EmitirSonido();

        public virtual string ResumenDeDatos() 
        {
            return $"Mi nombre es: {this.Nombre}";
        }

        public string NoVirtual() 
        {
            return "Metodo no virtual de la clase Animal";
        }
    }
}
