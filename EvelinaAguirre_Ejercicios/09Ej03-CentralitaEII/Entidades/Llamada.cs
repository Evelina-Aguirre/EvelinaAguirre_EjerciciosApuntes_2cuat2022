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

        public abstract float CostoLlamada { get; }
        public float Duracion { get => duracion;  }
        public string NroDestino { get => nroDestino;  }
        public string NroOrigen { get => nroOrigen; }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return (l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen);
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

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
