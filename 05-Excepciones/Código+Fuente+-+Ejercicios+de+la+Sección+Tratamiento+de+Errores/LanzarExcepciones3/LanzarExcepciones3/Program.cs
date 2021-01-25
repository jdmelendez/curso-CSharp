using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanzarExcepciones3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;

            Console.WriteLine("Introduce el Primer Número");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el Segundo Número");
            num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                resultado = num1 / num2;
                Console.WriteLine("El resultado de la operación es: {0}", resultado);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
            Console.ReadKey();
        }
    }
}
