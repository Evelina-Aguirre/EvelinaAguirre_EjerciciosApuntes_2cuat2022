using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Ej04_CentralitaEntidades
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        /*Las propiedades GananciaPorTotal, GananciaPorLocal y GananciaPorProvincial retornarán el precio 
         * de lo facturado según el criterio (llamada local, provincial o todas). Dichos valores se calcularán en el método CalcularGanancia.*/
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(ETipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(ETipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(ETipoLlamada.Todas);
            }
        }

        /*CalcularGanancia será privado. Este método recibe un enumerado TipoLlamada y
         * retornará el valor de lo recaudado, según el criterio elegido (ganancias por
         * las llamadas del tipo Local, Provincial o de Todas según corresponda).*/
        private float CalcularGanancia(ETipoLlamada tipo)
        {
            float recaudado=0;

            switch(tipo)
            {
                case ETipoLlamada.Local:

                    
                    foreach (Llamada item in this.listaDeLlamadas)
                    {
                        if(item is Local)
                        {
                            recaudado += ((Local)item).CostoLlamada;
                        }
                        
                    }
                    break;
                case ETipoLlamada.Provincial:

                    foreach (Llamada item in this.listaDeLlamadas)
                    {
                        if (item is Provincial)
                        {
                            recaudado += ((Provincial)item).CostoLlamada;
                        }

                    }
                    break;

                case ETipoLlamada.Todas:

                    foreach (Llamada item in this.listaDeLlamadas)
                    {
                        if(item is Local)
                        {
                            recaudado += ((Local)item).CostoLlamada;
                        }
                        else
                        {
                            recaudado += ((Provincial)item).CostoLlamada;

                        }
                    }
                    break;
            }

            return recaudado;
        }

        //El método Mostrar expondrá la razón social, la ganancia total,
        //ganancia por llamados locales y provinciales y el detalle de las llamadas realizadas.
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razón Social: {this.razonSocial}");
            sb.AppendLine($"Ganancia Total: {this.GananciasPorTotal}");
            sb.AppendLine($"Ganancia llam. Locales:  {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia llam. Provinciales: {this.GananciasPorProvincial}");

            foreach (Llamada item in this.listaDeLlamadas)
            {
                if(item is Local)
                {
                    ((Local)item).Mostrar();
                }
                else
                {
                    ((Provincial)item).Mostrar();
                }
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }




    }
}
