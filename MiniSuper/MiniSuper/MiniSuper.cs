using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper
{
    public static class MiniSuper
    {
        private static Usuario[] usuarios;

        static MiniSuper()
        {
            usuarios = new Usuario[0];
        }

        public static Usuario[] GetUsuarios()
        {
            return usuarios;
        }

        public static bool AgregarUsuario(Usuario user)
        {
            //TODO sobrecargar el == para ver si el user existe ya
            foreach (Usuario item in usuarios)
            {
                if (user == item)
                {
                    return false;
                }
            }
            //si recorri y el user no esta:
            //usuarios += user;//TODO sobrecargar +=
            Array.Resize<Usuario>(ref usuarios, usuarios.Length + 1);
            usuarios[usuarios.Length - 1] = user;

            return true;
        }
    }
}
