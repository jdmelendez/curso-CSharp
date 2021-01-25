using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLambda
{
    class Program
    {
        class Clientes
        {
            public string nombre { get; set; }
            public int edad { get; set; }
        }

        static void Main(string[] args)
        {
            // DECLARACIONES MULTIPLES DE EXPRESIONES LAMBDA
            

            // expresión lambda tipada de manera implicita, creamos una instancia a la expresión

            Func<int, int> expresion1 = x => x + 1;

            // usar la expresión lambda en el cuerpo de la declaración

            Func<int, int> expresion2 = x => { return x + 1; };

            // usamos parámetros en la expresión lambda

            Func<int, int> expresion3 = (int x) => x + 1;

            // usando parámetros en la expresión para usar en el cuerpo de la declaración

            Func<int, int> expresion4 = (int x) => { return x + 1; };

            // usa lambda con varios parámetros

            Func<int, int, int> expresion5 = (x, y) => x * y;

            // usar delegado en lugar de lambda con un parámetro. Realiza la misma función que la expresion3

            Func<int, int> expresion6 = delegate (int x) { return x + 1; };

            // usar delegado en lugar de lambda sin parámetros

            Func<int> expresion7 = delegate { return 1 + 1; };

            // usa lambda con sin parametros

            Func<int> expresion8 = () => 1 + 1;

            Console.WriteLine(expresion1.Invoke(1));
            Console.WriteLine(expresion2.Invoke(1));
            Console.WriteLine(expresion3.Invoke(1));
            Console.WriteLine(expresion4.Invoke(1));
            Console.WriteLine(expresion5.Invoke(1, 1));
            Console.WriteLine(expresion6.Invoke(1));
            Console.WriteLine(expresion7.Invoke());
            Console.WriteLine(expresion8.Invoke());
            Console.ReadKey();
            

            // DECLARACIÓN LAMDBA BÁSICA
            /*
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> pares = numeros.FindAll(x => (x % 2) == 0 );

            foreach (int p in pares)
            {
                Console.WriteLine("Los números pares son: {0}", p);
            }
            Console.ReadKey();
            */

            // DECLARACIONES LAMBDA CON CLASES
            /*
            List<Clientes> cliente = new List<Clientes>()
           {
                new Clientes {nombre = "Ángel", edad = 39 },
                new Clientes {nombre = "Patricia", edad = 37 }
           };

            var nombres = cliente.Select(x => x.nombre);

            foreach(var nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            Console.ReadKey();

            // ordenar por edad

            var edad = cliente.OrderBy(x => x.edad);

            foreach (var e in edad)
            {
                Console.WriteLine("El cliente {0}, tiene {1} años", e.nombre, e.edad);
            }

            Console.ReadKey();
            */
            /*
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var lista = numeros.FindAll((i) =>
           {
               Console.WriteLine("El valor de i es: {0}", i);
               return true;
           }
            );
            Console.ReadKey();
            */
        }
    }
}
