using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCondicionalIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 8;

            Console.WriteLine("¿Qué nota ha sacado el Alumno?");

            media = Convert.ToDouble(Console.ReadLine());

            string resultado = "El alumno ha ";

            resultado += media >= 7 ? "aprobado." : "suspenso.";

            Console.WriteLine(resultado);
           
            Console.ReadKey();

        }
    }
}
