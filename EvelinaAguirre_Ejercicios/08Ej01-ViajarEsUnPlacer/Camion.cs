using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Ej01_ViajarEsUnPlacer
{
    public class Camion :VehiculoTerrestre
    {
        //cantidad puetas
        //cantidad ruedas
        //color
        //cantidadMarchas
      
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, short cantidadPasajeros) 
            : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas, cantidadPasajeros)
        {
        }

        public Camion(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, short cantidadPasajeros, int pesoCarga)
            : this(cantidadRuedas, cantidadPuertas, color, cantidadMarchas, cantidadPasajeros)
        {
            this.pesoCarga = pesoCarga;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Cant Marchas: {this.CantidadMarchas}");
            sb.AppendLine($"Cant Pasajeros: {this.CantidadPasajeros}");
            sb.AppendLine($"peso Carga: {this.pesoCarga}");

            return sb.ToString();
        }
    }
}
