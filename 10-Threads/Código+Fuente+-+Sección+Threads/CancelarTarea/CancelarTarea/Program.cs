using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CancelarTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancelar = new CancellationTokenSource();
            CancellationToken token = cancelar.Token;

            Task tarea1 = new Task(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Se ha solicitado la cancelación de la tarea");
                        return;
                    }

                    Console.WriteLine("El resultado es: {0}", i);
                }

            }, token);

            Console.WriteLine("Pulsa una tecla para iniciar la tarea");
            Console.WriteLine("Pulsa una tecla para cancelar la tarea");
            Console.ReadKey();

            tarea1.Start();

            Console.ReadKey();

            Console.WriteLine("La tarea se está cancelando...");

            cancelar.Cancel();

            Console.WriteLine("La tarea de ha cancelado");

            Console.ReadKey();
        }
    }
}
