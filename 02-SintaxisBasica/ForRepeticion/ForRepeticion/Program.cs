using System;

namespace ForRepeticion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;

            Console.WriteLine("Introduce el Primer Número");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el Segundo Número");
            num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                result = num1 / num2;
                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }
            catch
            {
                Console.WriteLine("Se ha producido un error por División por Zero");
                throw;
            }
            Console.ReadLine();
        }
    }
}
