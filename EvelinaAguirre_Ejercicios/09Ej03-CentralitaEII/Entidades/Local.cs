using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Ej04_CentralitaEntidades
{
    public class Local:Llamada
    {
        protected float costo;


        public Local(Llamada llamada, float costo):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(float duracion, string nroDestino, string nroOrigen, float costo) 
            : this(new Llamada(duracion, nroDestino,nroOrigen), costo)  //💃
        {
        }

        //public Local(string origen, float duracion, string destino, float costo)
        //    :base(duracion, destino, origen)
        //{
        //    this.costo = costo;
        //}

        //public Local(Llamada llamada, float costo)
        //    : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        //{
        //}

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo:{this.CostoLlamada}");

            return sb.ToString();
        }


    }
}
