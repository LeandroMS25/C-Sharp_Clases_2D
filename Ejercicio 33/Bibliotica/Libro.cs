using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotica
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i] 
        {
            get 
            {
                string pagina = "Vacio";
                if (i >= 0 && i < paginas.Count)
                {
                    return this.paginas[i];
                }
                else 
                {
                    return pagina;
                }
            }
            set 
            {
                if (i >= 0 && i < paginas.Count)
                {
                    this.paginas[i] = value;
                }
                else
                {
                    this.paginas.Add(value);
                }
            }
        }
    }
}
