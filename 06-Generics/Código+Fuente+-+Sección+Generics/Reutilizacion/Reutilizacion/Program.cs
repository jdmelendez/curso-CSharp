using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reutilizacion
{
    public class usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
    }
    public class ListaElementos<T>
    {

        private List<T> elementos;

        public ListaElementos()
        {
            elementos = new List<T>();
        }

        public void Agregar (T nuevoelemento)
        {
            elementos.Add(nuevoelemento);
        }

        public void Eliminar (T eliminarelemento)
        {
            elementos.Remove(eliminarelemento);
        }
        static void Main(string[] args)
        {
            ListaElementos<int> Entero = new ListaElementos<int>();
            Entero.Agregar(1);
            Entero.Eliminar(1);

            ListaElementos<string> Cadenas = new ListaElementos<string>();
            Cadenas.Agregar("Ángel Arias");
            Cadenas.Eliminar("Ángel Arias");

            ListaElementos<usuario> Objetos = new ListaElementos<usuario>();
            Objetos.Agregar(new usuario { id = 1, nombre = "Ángel Arias" });
            Objetos.Eliminar(new usuario { id = 1, nombre = "Ángel Arias" });
        }
    }
}
