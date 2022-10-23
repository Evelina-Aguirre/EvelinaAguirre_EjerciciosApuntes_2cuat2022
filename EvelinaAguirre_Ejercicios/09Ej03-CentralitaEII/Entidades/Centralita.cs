﻿using System;
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

        private string Mostrar()
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
                    ((Provincial)item).ToString();
                }
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada l1)
        {
            this.Llamadas.Add(l1);
        }




    }
}
