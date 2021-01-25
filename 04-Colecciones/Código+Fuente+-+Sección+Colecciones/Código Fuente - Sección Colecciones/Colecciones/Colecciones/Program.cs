using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[2] { "Ángel Arias", "http://facebook.com/angelarias" };

            // bucle FOR

            for (IEnumerator e = nombres.GetEnumerator(); e.MoveNext(); Console.WriteLine(e.Current)) ;
            

            // bucle FOREACH

            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            Console.ReadKey();
        }
    }
}
