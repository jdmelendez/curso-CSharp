using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FicherosWindows
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo miDirectorio = new DirectoryInfo(@"C:/Windows");

            FileInfo[] fichero = miDirectorio.GetFiles();

            foreach (FileInfo f in fichero)
            {
                Console.WriteLine("El nombre del archivo es: {0} y tiene el tamaño de: {1} bytes", f.Name, f.Length);
            }
            Console.ReadKey();
        }
    }
}
