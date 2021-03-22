using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        public Boligrafo(short tinta, ConsoleColor color) 
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor() 
        {
            return color;
        }
        public short GetTinta()
        {
            return tinta;
        }
        private void SetTinta(short tinta) 
        {
            this.tinta = tinta;
        }
        public void Recargar() 
        {
            this.tinta = cantidadTintaMaxima;
        }
    }
}
