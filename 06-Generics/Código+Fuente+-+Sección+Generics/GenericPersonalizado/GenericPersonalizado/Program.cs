using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericPersonalizado
{
    class Program
    {
        public class ListaElementos<M>
        {
            private List<M> elementos;

            public ListaElementos()
            {
                elementos = new List<M>();
            }

            public void Agregar (M nuevoelemento)
            {
                elementos.Add(nuevoelemento);
            }

            public void Eliminar (M elementoeliminar)
            {
                elementos.Remove(elementoeliminar);
            }

            public void Listar()
            {
                foreach (var elemento in elementos)
                {
                    Console.WriteLine("El elemento es: {0}", elemento);
                }
            }
        }
        static void Main(string[] args)
        {
            ListaElementos<int> ListaEntera = new ListaElementos<int>();
            ListaEntera.Agregar(1);
            ListaEntera.Agregar(2);
            ListaEntera.Agregar(3);
            ListaEntera.Eliminar(2);

            ListaEntera.Listar();
            Console.ReadKey();

            ListaElementos<string> ListaCadena = new ListaElementos<string>();
            ListaCadena.Agregar("Ángel Arias");
            ListaCadena.Agregar("Patricia");
            ListaCadena.Agregar("Paco");
            ListaCadena.Eliminar("Paco");

            ListaCadena.Listar();
            Console.ReadKey();
        }
    }
}
