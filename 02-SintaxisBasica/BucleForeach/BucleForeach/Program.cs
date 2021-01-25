using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pilotos = new string[4] { "Alonso", "Hamilton",
     "Vettel", "Sainz" };
            Console.WriteLine(pilotos[3]);
            Console.WriteLine();
            pilotos[3] = "Vettel";
            foreach (string piloto in pilotos)
            {
                Console.WriteLine(piloto);
            }
            Console.ReadKey();

        }
    }
}
