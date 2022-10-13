using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApuntesClase08
{
    public class Perro : Mascota
    {
        private string raza;
        public Perro(string nombre, int patas,string sexo):base(nombre,patas,sexo)
        {

        }

        public Perro(string nombre, int patas, string sexo, string raza) : this(nombre, patas, sexo)
        {
            this.raza = raza;
        }

        public string Ladrar()
        {
            //return this.Saludar();//Perro toma saludar como suyo cuando es uhn método de la clase padre
            return this.nombre + "GUAG";
        }
        //La estrellita en e ldrigrama de clases es protected.. se puede acceder solamente en la clase 
        //modificador de visisbilidad puede acceder solo su clase y las que hereden de ella 



    }
}
