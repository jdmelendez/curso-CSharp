using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesLambda
{
    class Program
    {
     //   delegate int delegado(int i);
        static void Main(string[] args)
        {
            /*
            delegado miDelegado = y => y * y;
            int j = miDelegado(5);
            Console.WriteLine(j);
            Console.ReadKey();
            */
            /*
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 25, 27, 29, 50 };

            double valorMedio = numeros.Where(num => num % 2 == 1).Average();
            Console.WriteLine(valorMedio);
            Console.ReadKey();
            */

            // Árboles de expresión

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int i in numeros.Where(x =>
            {
                if (x <= 3)
                    return true;
                else if (x >= 7)
                    return true;
                return false;
            }
            ))
                Console.WriteLine(i);
            Console.ReadKey();
            
        }
    }
}
