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

        //public Local(float duracion, string nroDestino, string nroOrigen, float costo) 
        //    : base(new Llamada(duracion, nroDestino,nroOrigen), costo)  //💃
        //{
        //}

        //public Local(Llamada llamada, float costo):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        //{
        //    this.costo = costo;
        //}
        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string destino, float duracion, string origen, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }



        public override float CostoLlamada
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

        public override bool Equals(object obj)
        {
            return obj is Local;
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
