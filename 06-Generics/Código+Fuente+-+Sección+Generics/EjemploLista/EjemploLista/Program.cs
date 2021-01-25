using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploLista
{
    class Program
    {
        static void Main(string[] args)
        {
            // Agregar Elementos Lista
            IList<int> entero = new List<int>();

            entero.Add(2);
            entero.Add(3);

            IList<string> cadena = new List<string>();

            cadena.Add("dos");
            cadena.Add("tres");

            IList<int> entero1 = new List<int>() { 2, 3 };
            IList<string> cadena1 = new List<string>() { "dos", "tres" };

            // método AddRange

            List<int> entero3 = new List<int>();
            entero3.AddRange(entero);

            // Acceder a los elementos colección List

            Console.WriteLine("El valor en la posición 1 de mi lista es: {0}", entero[0]);
            foreach (int i in entero)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < entero.Count; i++)
            {
                Console.WriteLine(entero[i]);
            }

            // Insertar elementos a la colección genérica List

            IList<int> entero4 = new List<int>() { 2, 3 };

            entero4.Insert(1, 5);

            foreach (var i in entero4)
            {
                Console.WriteLine(i);
            }

            // Eliminar elementos de la colección genérica list

            IList<int> entero5 = new List<int>() { 1, 2, 3, 4 };

            entero5.Remove(2); //eliminar el primer valor número 2 que encuentre en la lista

            entero5.RemoveAt(2); // eliminar el elemento que está en la segunda posición de la lista

            foreach (var i in entero5)
            {
                Console.WriteLine(i);
            }
        }
    }
}
