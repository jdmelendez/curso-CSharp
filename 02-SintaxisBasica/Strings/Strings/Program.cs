using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // método substring
            string nombre = "Alexandre Gonzalez";
            string apellidos = nombre.Substring(10, 8);
            

            Console.WriteLine(apellidos);
            

            // método IndexOf

            string nombre1 = "Alexandre Gonzalez - Programando en C#";
            int posicion1 = nombre1.IndexOf("Programando");
            Console.WriteLine(posicion1);
            int posicion2 = nombre1.IndexOf("Gonzalez", 5);
            Console.WriteLine(posicion2);
            

            // métodos ToUpper y ToLower

            string nombre2 = "Juan García Robles";
            string minusculas;
            string mayusculas;

            minusculas = nombre2.ToLower();
            mayusculas = nombre2.ToUpper();

            Console.WriteLine(minusculas);
            Console.WriteLine(mayusculas);

            // funciones Startswith y Endswith

            string archivo = "comctl32.dll";
            if (archivo.StartsWith("com"))
            {
                Console.WriteLine("El archivo comienza con el texto COM");
            }
            if (archivo.EndsWith(".dll"))
            {
                Console.WriteLine("Este archivo es una librería");
            }

            // funciones TrimStart, TrimEnd y Trim

            string nombre3 = " Rodríguez ";

            string ejemplo1 = nombre3.TrimStart();
            Console.WriteLine(ejemplo1);
            string ejemplo2 = nombre3.TrimEnd();
            Console.WriteLine(ejemplo2);
            string ejemplo3 = nombre3.Trim();
            Console.WriteLine(ejemplo3);

            // funciones PadLeft y PadRight

            string nombre4 = "Gonzalez";
            string codigo = "123";

            nombre4 = nombre4.PadRight(10, 'X');
            codigo = codigo.PadLeft(6, '0');
            Console.WriteLine(nombre4 + codigo);

            // funciones Split y Join

            string linea = "Prueba, 10, 20, 10/09/2018";
            string[] campos = linea.Split(new char[] { ',' });
            Console.WriteLine(campos[0]);
            Console.WriteLine(campos[1]);
            Console.WriteLine(campos[2]);
            Console.WriteLine(campos[3]);

            string lineanueva = String.Join(";", campos);
            Console.WriteLine(lineanueva);

            // función format

            string formato = String.Format("Aquí voy a poner el {0}. Ahora son las {1}. Este es un valor numérico: {2}", "Parámetro que yo quiera poner", DateTime.Now, 15);
            Console.WriteLine(formato);

            // método Replace

            string texto1 = "Curso de Desarrollo en C# - Curso de ASP.NET MVC de Ángel Arias";
            string nuevotexto1 = texto1.Replace(" Curso ", " Video Curso ");
            Console.WriteLine(nuevotexto1);

            // método Length

            string texto2 = "Ángel Arias. Cursos de Desarrollo Informático";
            int numerotexto2 = texto2.Length;
            Console.WriteLine(numerotexto2);
            Console.ReadKey();
        }
    }
}
