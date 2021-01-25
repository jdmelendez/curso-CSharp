using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfazexplicita
{
    class Program
    {
        public interface IOrganismo
        {
            void respirar();
            void mover();
        }

        public interface IAnimal
        {
            void mover();
            void viviparo();
        }

        class Perro : IOrganismo, IAnimal
        {
            public void respirar()
            {
                Console.WriteLine("Este Organismo respira");
            }

            void IOrganismo.mover()
            {
                Console.WriteLine("Este Organismo se mueve");
            }

            void IAnimal.mover()
            {
                Console.WriteLine("Este Animal se mueve");
            }

            public void viviparo()
            {
                Console.WriteLine("Este Organismo es Vivíparo");
            }
        }
        static void Main(string[] args)
        {
            Perro perros = new Perro();
            IOrganismo organismo = perros;
            IAnimal animal = perros;

            perros.respirar();
            perros.viviparo();

            organismo.mover();
            animal.mover();

            Console.ReadKey();
        }
    }
}
