using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Ej04_CentralitaEntidades
{
    public class Provincial : Llamada
    {
        protected EFranja franjaHoraria;

        public Provincial(EFranja miFranja, Llamada llamada):base (llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(string nroOrigen, EFranja miFranja, float duracion, string nroDestino) 
            : this(miFranja, new Llamada(duracion, nroDestino, nroOrigen))//🙏
        {
            
        }

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float costo=0;
            switch(this.franjaHoraria)
            {
                case EFranja.Franja_1:
                    costo = base.Duracion * (float)0.99;
                    break;
                case EFranja.Franja_2:
                    costo = base.Duracion * (float)1.25;
                    break;
                case EFranja.Franja_3:
                    costo = base.Duracion * (float)0.66;
                    break;
            }
            return costo;

        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo:{this.CostoLlamada}");
            sb.AppendLine($"FranjaHoraria:{this.franjaHoraria}");

            return sb.ToString();

        }



    }
}
