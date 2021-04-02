using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca() 
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p) 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de Barra: {p.codigoDeBarra}");
            sb.AppendLine($"Marca: {p.marca}");
            sb.AppendLine($"Precio: {p.precio}");
            return sb.ToString();
        }

        public static explicit operator string(Producto p) 
        {
            return p.codigoDeBarra;
        }
        
        public static bool operator ==(Producto p1, Producto p2) 
        {

            if (!(p1 is null || p2 is null))
            {
                return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        

        public static bool operator ==(Producto p1, string cadena)
        {
            if (p1.marca == cadena)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Producto p1, string cadena)
        {
            return !(p1.marca == cadena);
        }
    }
}
