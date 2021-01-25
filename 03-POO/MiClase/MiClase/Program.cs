using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.hablar();
            p.setNombre("Ángel Arias");
            Console.WriteLine("El Nombre: " + p.getNombre() + " ha sido modificado");
            Console.ReadKey();
        }
    }
}
