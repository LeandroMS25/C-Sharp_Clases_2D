using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private Mascota[] mascotas;

        public Cliente(string nombre, string apellido, string domicilio, string telefono) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.mascotas = new Mascota[10];
        }

        public void CambiarMascota(Mascota mascota,int indice) 
        {
            this.mascotas[indice] = mascota;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {this.nombre}");
            stringBuilder.AppendLine($"Apellido: {this.apellido}");
            stringBuilder.AppendLine($"Domicilio: {this.domicilio}");
            stringBuilder.AppendLine($"Telefono: {this.telefono}");
            stringBuilder.AppendLine($"Mascota: {this.mascotas[0].Mostrar()}");
            return stringBuilder.ToString();
        }
    }
}
