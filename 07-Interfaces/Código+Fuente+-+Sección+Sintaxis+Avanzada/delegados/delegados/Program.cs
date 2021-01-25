using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int numeros(int n);

namespace delegados
{
    class Program
    {
        static int numero = 10;

        public static int sumarNumeros(int p)
        {
            numero += p;
            return numero;
        }

        public static int multiplicarNumero(int p)
        {
            numero *= p;
            return numero;
        }

        public static int obtenerNumero()
        {
            return numero;
        }
        static void Main(string[] args)
        {
            numeros num;
            numeros numero1 = new numeros(sumarNumeros);
            numeros numero2 = new numeros(multiplicarNumero);

            num = numero1;
            num += numero2;

            num(5);

            Console.WriteLine("El valor de la variable num es: {0}", obtenerNumero());

            /*
            numero1(10);
            Console.WriteLine("El valor de la instancia numero1 es: {0}", obtenerNumero());

            numero2(5);
            Console.WriteLine("El valor de la instancia numero2 es: {0}", obtenerNumero());
            */
            Console.ReadKey();
        }
    }
}
