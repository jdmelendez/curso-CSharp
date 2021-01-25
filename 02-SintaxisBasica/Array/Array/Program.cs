using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pilotos = new string[4] { "Alonso", "Hamilton", "Vettel", "Sainz" };
            Console.WriteLine(pilotos[3]);
            pilotos[3] = "Senna";
            Console.WriteLine(pilotos[3]);
            Console.ReadKey();
        }
    }
}
