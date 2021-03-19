using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string name;
        public string lastName;
        public int legajo;
        public Alumno(string name,string lastName, int legajo) 
        {
            this.name = name;
            this.lastName = lastName;
            this.legajo = legajo;
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Nombre: {this.name}");
            stringBuilder.Append($"Apellido: {this.lastName}");
            stringBuilder.Append($"Legajo: {this.legajo}");
            if (this.notaFinal != -1)
            {
                stringBuilder.Append($"Nota Final: {this.notaFinal}");
            }
            else
            {
                stringBuilder.Append("Alumno desaprobado.");
            }
            return stringBuilder.ToString();
        }
        public void Estudiar(byte notaUno, byte notaDos) 
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                /*
                Random rdm = new Random();
                this.notaFinal = rdm.Next(4,10);
                */
                this.notaFinal = (float)(this.nota1 + this.nota2) / (float)2;
            }
            else
            {
                this.notaFinal = -1;
            }
        }
    }
}
