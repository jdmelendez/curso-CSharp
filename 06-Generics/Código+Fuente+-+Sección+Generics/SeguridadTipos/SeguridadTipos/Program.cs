using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SeguridadTipos
{
    class Program
    {
        public class usuario
        {
            int id { get; set; }
            string nombre { get; set; }
        }
        static void Main(string[] args)
        {
            // Colección NO Genérica ArrayList
            //   ArrayList objetos = new ArrayList();

            //    objetos.Add(1);
            //    objetos.Add("Ángel Arias");
            //    objetos.Add(new usuario());

            //    foreach (int i in objetos)
            //    {
            //        Console.WriteLine(i);
            //    }
            //     Console.ReadKey();

            // Colección Genérica List<T>

            List<int> objetos = new List<int>();

            objetos.Add(1);
            objetos.Add(2);
            objetos.Add(3);

            foreach (int i in objetos)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}