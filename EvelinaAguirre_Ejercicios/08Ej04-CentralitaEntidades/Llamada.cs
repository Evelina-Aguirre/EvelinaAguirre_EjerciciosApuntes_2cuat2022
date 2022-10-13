using System;
using System.Text;

namespace _08Ej04_CentralitaEntidades
{
    public class Llamada
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

        public float Duracion { get => duracion;  }
        public string NroDestino { get => nroDestino;  }
        public string NroOrigen { get => nroOrigen; }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Duración: {this.duracion}");
            sb.AppendLine($"Destino: {this.nroDestino}");
            sb.AppendLine($"Origen: {this.nroOrigen}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            
            //int resultado=0; 
            //if(llamada1.duracion > llamada2.duracion)
            //{
            //    resultado = 1;
            //}
            //else
            //{
            //    resultado = 2;
            //}
            //return resultado;

            return llamada1.Duracion.CompareTo(llamada2.Duracion);

        }
    }
        
}
