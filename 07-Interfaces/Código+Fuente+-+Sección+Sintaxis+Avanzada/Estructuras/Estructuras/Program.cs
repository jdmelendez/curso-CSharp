using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    class Program
    {
        // Definición de Estructura 1
        /*
        struct Libros
        {
            public string titulo;
            public string autor;
            public string categoria;
            public int id_libro;
        }
        */

            struct Libros
        {
            public string titulo;
            public string autor;
            public string categoria;
            public int id_libro;

            public void getValores(string t, string a, string c, int id)
            {
                titulo = t;
                autor = a;
                categoria = c;
                id_libro = id;
            }

            public void mostrar()
            {
                Console.WriteLine("Título es: {0}", titulo);
                Console.WriteLine("Autor es: {0}", autor);
                Console.WriteLine("Categoría es: {0}", categoria);
                Console.WriteLine("ID es: {0}", id_libro);
            }
        }
        static void Main(string[] args)
        {
            /*
            Libros libro1;
            Libros libro2;

            libro1.titulo = "La Computación en la Nube";
            libro1.autor = "Ángel Arias";
            libro1.categoria = "Sistemas Operativos en la Nube";
            libro1.id_libro = 123;

            libro2.titulo = "Aprende a Programar en C Sharp";
            libro2.autor = "Ángel Arias";
            libro2.categoria = "Desarrollo Informático";
            libro2.id_libro = 124;

            Console.WriteLine("Estos son los datos del Libro 1");
            Console.WriteLine("El título es: {0}", libro1.titulo);
            Console.WriteLine("El autor es: {0}", libro1.autor);
            Console.WriteLine("La Categoría es: {0}", libro1.categoria);
            Console.WriteLine("El id del libros es: {0}", libro1.id_libro);
            Console.WriteLine("");
            Console.WriteLine("Estos son los datos del Libro ");
            Console.WriteLine("El título es: {0}", libro2.titulo);
            Console.WriteLine("El autor es: {0}", libro2.autor);
            Console.WriteLine("La Categoría es: {0}", libro2.categoria);
            Console.WriteLine("El id del libros es: {0}", libro2.id_libro);

            Console.ReadKey();
            */

            Libros libro1 = new Libros();
            Libros libro2 = new Libros();

            libro1.getValores("La Computación en la Nube", "Ángel Arias", "Sistemas Operativos en la Nube", 123);
            libro2.getValores("Aprende a Programar en C Sharp", "Ángel Arias", "Desarrollo Informático", 124);

            libro1.mostrar();
            libro2.mostrar();

            Console.ReadKey(); 
        }
    }
}
