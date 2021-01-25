using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;

            double radio;

            Console.WriteLine("Introduzca el valor del radio:");
            radio = Convert.ToDouble(Console.ReadLine());

            double areaCirculo = pi * radio * radio;

            Console.WriteLine("El Radio es: {0}, y el Área del Círculo es: {1}", radio, areaCirculo);

            Console.ReadKey();
            
                            
            
        }
    }
}
