using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EjemploCompletoThreads
{
    class Program
    {
        static void Imprimir1()
        {
            Console.WriteLine("Se está ejecutando el Método Imprimir1()");

            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("Ejecutando el Hilo1...");
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }

        static void Imprimir2()
        {
            Console.WriteLine("Se está ejecutando el Método Imprimir2()");

            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("Ejecutando el Hilo2...");
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Thread hilo1 = new Thread(new ThreadStart(Imprimir1));
            Thread hilo2 = new Thread(new ThreadStart(Imprimir2));

            hilo1.Name = "Principal";
            hilo2.Name = "Secundario";

            Console.WriteLine("Elige la siguiente Opción:/n");
            Console.WriteLine("1. Los Hilos se ejecutarán en Paralelo");
            Console.WriteLine("2. Se ejecutarán los Hilos en Primer o Segundo Plano");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                hilo1.Start();
                hilo2.Start();
            }

            if (opcion == 2)
            {
                Console.WriteLine("Se van a ejecutar los Hilos en Primer o Segundo Plano");
                Console.WriteLine("Selecciona 1 para ejecutar el hilo en Primer Plano y selecciona 2 para ejecutar el Hilo en Segundo Plano");

                int numeros = int.Parse(Console.ReadLine());

                switch (numeros)
                {
                    case 1:
                        PrimerPlano();
                        break;
                    case 2:
                        SegundoPlano();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("El Método Principal se ha Completado...");
            } 
        }

        static void Retrasar()
        {
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("Ejecutando el hilo...");
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }

        static void PrimerPlano()
        {
            Thread primerplano = new Thread(new ThreadStart(Retrasar));
            primerplano.Start();
        }

        static void SegundoPlano()
        {
            Thread segundoplano = new Thread(new ThreadStart(Retrasar));
            segundoplano.IsBackground = true;
            segundoplano.Start();
        }
    }
}
