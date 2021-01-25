using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pilotos = new string[4] { "Alonso", "Hamilton", "Verstappen", "Sainz" };
            Console.WriteLine(pilotos[2]);
            Console.WriteLine();
            pilotos[2] = "Vettel";
            foreach (string piloto in pilotos)
            {
                Console.WriteLine(piloto);
            }
            Console.ReadKey();
        }
    }
}
