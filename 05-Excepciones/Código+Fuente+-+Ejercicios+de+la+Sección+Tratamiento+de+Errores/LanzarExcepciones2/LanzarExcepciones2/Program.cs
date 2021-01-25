using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanzarExcepciones2
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
                if (num2 == 0)
                {
                    throw new Exception("No se puede Dividir entre Cero (0)");
                }

                resultado = num1 / num2;
                Console.WriteLine("{0}", "{1}", "{2}", num1, num2, resultado);
            }
            catch (Exception e)
            {
                Console.WriteLine("Se ha capturado la Excepción: {0}", e.ToString());
            }
            Console.ReadKey();
         }
    }
}
