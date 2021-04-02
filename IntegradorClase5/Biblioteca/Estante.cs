using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad) 
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacionEstante)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }

        public Producto[] GetProductos() 
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e) 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicacion del estante: {e.ubicacionEstante}\n");
            foreach (Producto producto in e.productos)
            {
                if (!(producto is null)) 
                {
                    sb.AppendLine(Producto.MostrarProducto(producto));
                    sb.AppendLine("-------------------------------\n");
                }
            }
            return sb.ToString(); 
        }

        public static bool operator ==(Estante e, Producto p) 
        {
            foreach (Producto producto in e.productos)
            {
                if (producto == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if (e != p) 
            {
                for(int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e == p)
                {
                    e.productos[i] = null;
                    break;
                }
            }
            return e;
        }
    }
}
