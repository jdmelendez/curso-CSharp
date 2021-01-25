using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObtenerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> tarea1 = new Task<int>(() => 
            {
                int resultado = 1;

                for (int i = 1; i < 10; i++)
                {
                    resultado *= i;
                }

                return resultado;
            });

            tarea1.Start();

            Console.WriteLine("El resultado de la tarea es: {0}", tarea1.Result);

            Console.ReadKey();
        }
    }
}
