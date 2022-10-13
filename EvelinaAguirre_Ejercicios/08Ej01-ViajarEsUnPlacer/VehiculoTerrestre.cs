using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Ej01_ViajarEsUnPlacer
{
    public class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private EColores color;
        private short cantidadMarchas;
        private short cantidadPasajeros;



        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColores color, short cantidadMarchas, short cantidadPasajeros):this(cantidadPuertas, cantidadRuedas, color)
        {
            
            this.CantidadMarchas = cantidadMarchas;
            this.CantidadPasajeros = cantidadPasajeros;

        }

        public short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas = value; }
        public short CantidadPasajeros { get => cantidadPasajeros; set => cantidadPasajeros = value; }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("///////////////////////");
            sb.AppendLine($"cant Ruedas: { this.cantidadRuedas} ");
            sb.AppendLine($"cant Puertas: { this.cantidadPuertas} ");
            sb.Append($"color: {this.color}");
            

            return sb.ToString();
       
        }

       

    }
}
