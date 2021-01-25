using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraAplicacionConsola
{
    public class Persona
    {
        public Persona(string cabelo) //Valor obrigatório
        {
            Ojos = 2; //Valor default
            Brazos = 2;
            Piernas = 2;
            Color_Cabello = "cabello";
        }
        public Persona()
        {
        }
        public string Nombre { get; set; }
        public int Ojos { get; set; }
        public string Color_Cabello { get; set; }
        public int Brazos { get; set; }
        public int Piernas { get; set; }
    }




}
