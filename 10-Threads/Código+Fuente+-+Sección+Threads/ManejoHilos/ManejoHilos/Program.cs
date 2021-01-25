using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ManejoHilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread hilo = Thread.CurrentThread;

            hilo.Name = "Hilo Principal de la Aplicación";

            Console.WriteLine("El Hilo Principal se llama {0}", hilo.Name);
            Console.ReadKey();
        }
    }
}
