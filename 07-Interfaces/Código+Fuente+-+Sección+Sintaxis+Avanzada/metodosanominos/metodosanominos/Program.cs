using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void numeros(int n);

namespace metodosanominos
{
    class Program
    {
        static int numero = 10;

        public static void sumarNumeros(int n)
        {
            numero += n;
            Console.WriteLine("Este método tiene el valor: {0}", numero);
        }

        public static void multiplicarNumeros(int n)
        {
            numero *= n;
            Console.WriteLine("Este método tiene el valor: {0}", numero);
        }

        public static int obtenerNumero()
        {
            return numero;
        }
        static void Main(string[] args)
        {
            numeros num = delegate (int x)
            {
                Console.WriteLine("El valor de este método es: {0}", x);
            };

            num(10);

            num = new numeros(sumarNumeros);
            num(5);

            num = new numeros(multiplicarNumeros);
            num(2);

            Console.ReadKey();
        }
    }
}
