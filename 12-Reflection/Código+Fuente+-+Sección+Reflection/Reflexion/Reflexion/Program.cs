using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflexion
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly Miensamblaje = Assembly.LoadFile(@"C:\Users\acer\Documents\Visual Studio 2015\Projects\Reflexion\Calculadora\bin\Debug\Calculadora.dll");

            Type MiTipo = Miensamblaje.GetType("Calculadora.Class1");

            object instancia = Activator.CreateInstance(MiTipo);

            Type ObjTipo = instancia.GetType();

            foreach (MemberInfo objeto in ObjTipo.GetMembers())
            {
                Console.WriteLine(objeto.Name);
            }
            Console.ReadKey();
        }
    }
}
