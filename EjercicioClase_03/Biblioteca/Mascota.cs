using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        private string nombre;
        private string especie;
        private DateTime fechaNacimiento;
        private string historialVacunacion;

        public Mascota(string nombre, string especie, DateTime fechaNacimiento) 
        {
            this.nombre = nombre;
            this.especie = especie;
            this.fechaNacimiento = fechaNacimiento;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {this.nombre}");
            stringBuilder.AppendLine($"Especie: {this.especie}");
            stringBuilder.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento.ToShortDateString()}");
            return stringBuilder.ToString();
        }
    }
}
