using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Ej01_ViajarEsUnPlacer
{
    public class Moto : VehiculoTerrestre
    {
        

        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, EColores color) : base(cantidadRuedas, cantidadPuertas, color)
        {
        }

       
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Cilindrada: {this.cilindrada}");
            return sb.ToString();
        }
    }
}
