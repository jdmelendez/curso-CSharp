using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //implementación de la Clase Queue

            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            Console.WriteLine("Los Elementos de la Cola son:");

            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }

            Console.WriteLine("Ahora el contenido de nuestra Cola son:" + q.Count);


            // implementación de la Clase Stack

            Stack s = new Stack();

            s.Push(1);
            s.Push(2);
            s.Push(3);

            Console.WriteLine("Los Elementos que tenemos en la Pila son:");

            while (s.Count > 0)
            {
                Console.WriteLine(s.Pop());
            }

            Console.WriteLine("Los Elementos que hay ahora en la Pila son: " + s.Count);
            Console.ReadKey();
        }
    }
}
