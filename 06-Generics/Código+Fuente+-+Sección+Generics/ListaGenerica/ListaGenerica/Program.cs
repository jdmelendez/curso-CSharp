using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> entero = new List<int>();

            entero.Add(1);
            entero.Add(2);
            entero.Add(3);

            for (int i=0; i < entero.Count; i++)
            {
                Console.WriteLine("El valor entero es: {0}", entero[i]);
            }
            Console.ReadKey();

            List<string> cadena = new List<string>();

            cadena.Add("Primero");
            cadena.Add("Segundo");
            cadena.Add("Tercero");

            for (int i=0; i < cadena.Count; i++)
            {
                Console.WriteLine("El valor de la cadena es: {0}", cadena[i]);
            }
            Console.ReadKey();
        }
    }
}
