using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApuntesClase08
{
    public abstract class Mascota //Le pongo abstract para que no sea instanciable y solo se pueden crear objetos de Gato y perro
        //El modificador sealed, es unqa clase de la que no se puede derivar 
    {
        protected string nombre;
        private int patas;
        private string sexo;
           

        public Mascota(string nombre, int patas, string sexo)
        {
            this.nombre = nombre;
            this.patas = patas;
            this.sexo = sexo;

        }

        public string Saludar()
        {
            return $"Hola soy {this.nombre}";
        }







    }
}
