using System;
using System.Text;

namespace _08Ej04_CentralitaEntidades
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float CostoLlamada;
        public float Duracion { get => duracion;  }
        public string NroDestino { get => nroDestino;  }
        public string NroOrigen { get => nroOrigen; }

        public static bool operator ==(Llamada l1, Llamada l2)
        {

        }
        /*El operador == comparará dos llamadas y retornará true si las llamadas
         * son del mismo tipo (utilizar el método Equals, sobrescrito en las clases 
         * derivadas) y los números de destino y origen son iguales en ambas llamadas.*/
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Duración: {this.duracion}");
            sb.AppendLine($"Destino: {this.nroDestino}");
            sb.AppendLine($"Origen: {this.nroOrigen}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {

            return llamada1.Duracion.CompareTo(llamada2.Duracion);

        }
    }
        
}
