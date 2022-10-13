using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Ej01_ViajarEsUnPlacer
{
    public class Automovil : VehiculoTerrestre
    {
        //cnt ruedas
        //cntpuertas
        //colores
        //cant marchas
        //cantPasajeros
        public Automovil(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, short cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas, cantidadPasajeros)
        {
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Cant Marchas: {this.CantidadMarchas}");
            sb.AppendLine($"Cantidad Pasajeros: {this.CantidadPasajeros}");
            return sb.ToString();
        }
    }
}
