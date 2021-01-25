using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class AgregarNumero
    {
        public delegate void delegado_Impar();
        public event delegado_Impar evento_Impar;

        public void Agregar()
        {
            int resultado;
            resultado = 5 + 4;
            Console.WriteLine(resultado.ToString());

            if (resultado %2 != 0)
            {
                evento_Impar();
            }
        }
    }
    class Program
    {
        static void EventoMensaje()
        {
            Console.WriteLine("Se ha Ejecutado el Evento. Este es un número Impar");
        }
        static void Main(string[] args)
        {
            AgregarNumero a = new Eventos.AgregarNumero();
            a.evento_Impar += new AgregarNumero.delegado_Impar(EventoMensaje);
            a.Agregar();
            Console.ReadKey();
        }

    }
}
