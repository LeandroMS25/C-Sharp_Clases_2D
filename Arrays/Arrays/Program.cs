using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--------------PILAS--------------");
            
            //LIFO - Ultimo en entrar, primero en salir
            Stack<string> pila = new Stack<string>();
            pila.Push("Juan Perez"); // Agregar
            pila.Push("Fede");
            pila.Push("Griselda");

            foreach (string nombre in pila)
            {
                Console.WriteLine(nombre);
            }

            // El metodo Peek devuelve el siguiente elemento sin eliminarlo
            Console.WriteLine(pila.Peek());

            // Saca un elemento de la cola en orden lifo.
            Console.WriteLine(pila.Pop());

            Console.WriteLine("\n--------------COLAS--------------");

            Queue<string> colaDeAtencion = new Queue<string>();
            colaDeAtencion.Enqueue("Juan Perez"); // Agregar
            colaDeAtencion.Enqueue("Fede");
            colaDeAtencion.Enqueue("Griselda");

            foreach (string nombre in colaDeAtencion)
            {
                Console.WriteLine(nombre);
            }

            // El metodo Peek devuelve el siguiente elemento sin eliminarlo
            Console.WriteLine(colaDeAtencion.Peek());

            // Saca un elemento de la cola en orden fifo.
            Console.WriteLine(colaDeAtencion.Dequeue());

            Console.WriteLine("\n--------------DICCIONARIOS--------------");

            Dictionary<string, int> guiaTelefonica = new Dictionary<string, int>();
            guiaTelefonica.Add("Leandro", 651889); // Agregar
            guiaTelefonica.Add("Sobrino", 1861686); // No se puede repetir la clave.

            foreach (KeyValuePair<string, int> parClaveValor in guiaTelefonica)
            {
                Console.WriteLine($"Apellido: {parClaveValor.Key} Telefono: {parClaveValor.Value}");
            }

            Console.WriteLine($"Busco por clave 'Leandro' y devuelve {guiaTelefonica["Leandro"]}");
            guiaTelefonica["Leandro"] = 42429218;
            Console.WriteLine($"Busco por clave 'Leandro' y devuelve {guiaTelefonica["Leandro"]}");

            // Muestro claves
            foreach (string key in guiaTelefonica.Keys)
            {
                Console.WriteLine(key);
            }

            // Muestro valores
            foreach (int value in guiaTelefonica.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine($"Cantidad: {guiaTelefonica.Count}");
            Console.WriteLine($"¿Contiene la clave Leandro? {guiaTelefonica.ContainsKey("Leandro")}");
            Console.WriteLine($"¿Contiene la clave Leandro? {guiaTelefonica.ContainsValue(42429218)}");

            guiaTelefonica.Clear(); // Limpiar la coleccion

            Console.WriteLine("\n--------------LISTAS--------------");

            List<int> numeros = new List<int>();
            numeros.Add(1); // Agregar elementos
            numeros[0] = 2; // Asignar
            int numero = numeros[0]; // Leer
            numeros.Add(5);
            numeros.Add(3);
            numeros.Sort(); // ORDENA

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            // Obtener el indice del primer objeto que matchee (==)
            int indice = numeros.IndexOf(5);

            // Eliminar un elemento del indice especificado.
            numeros.RemoveAt(indice);

            // Eliminar el primer elemento que matchee (==)
            numeros.Remove(3);

            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("\n--------------ARRAYS--------------");
            // Declarar
            string[] nombres;

            // Instanciar
            nombres = new string[4];
            /*
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            */
            // Inicializar / Asignar valores
            nombres[0] = "Leandro";
            nombres[1] = "Leandro";
            nombres[2] = "Leandro";
            nombres[3] = "Leandro";

            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            nombres.Clone(); // Genera una copia del Array.
            int dimensiones = nombres.Rank; // Numero de dimensiones del Array.
            Console.WriteLine($"Dimensiones: {dimensiones}"); // Imprimimos la cantidad.

            Array.Resize(ref nombres, 5);

            foreach (string nombre in nombres)
            {
                if (nombre is null)
                {
                    Console.WriteLine("Null");
                }
                else 
                {
                    Console.WriteLine(nombre);
                }
            }

            string[,] personas = new string[3, 2];
            personas[0, 0] = "Leandro";
            personas[0, 1] = "39107331";
            personas[1, 0] = "Leandro";
            personas[1, 1] = "39107331";
            personas[2, 0] = "Leandro";
            personas[2, 1] = "39107331";

            string[,] personas2 = { { "Leandro", "39107331" }, { "Leandro", "39107331" } };
            int dimensiones2 = personas2.Rank; // Numero de dimensiones del Array.
            Console.WriteLine($"Dimensiones: {dimensiones2}");
            Console.WriteLine($"Posiciones: {personas2.Length}");
            Console.WriteLine($"Tamaño dimension 1: {personas2.GetLength(0)}");

            for (int i = 0; i <= personas2.GetLength(0); i++)
            {
                Console.WriteLine($"Nombre: {personas[i, 0]} - DNI: {personas[i, 1]}");
            }

            // Jagged Array
            string[][] arrayDeArrays = new string[2][];
            arrayDeArrays[0] = new string[1] { "Casa" };
            arrayDeArrays[1] = nombres;

            Console.WriteLine(arrayDeArrays[0]);
            Console.WriteLine(arrayDeArrays[0][0]);

            Console.ReadKey();
        }
    }
}
