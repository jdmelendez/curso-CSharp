using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachRepeticion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Angel", "Patricia", "Luis", "Maria" };

            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            Console.ReadKey();
        }
    }
}
