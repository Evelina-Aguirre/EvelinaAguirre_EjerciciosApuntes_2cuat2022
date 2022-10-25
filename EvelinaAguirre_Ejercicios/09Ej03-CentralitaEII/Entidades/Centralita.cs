using System.Collections.Generic;
using System.Text;

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

        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }
        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(ETipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(ETipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(ETipoLlamada.Todas);
            }
        }

        private float CalcularGanancia(ETipoLlamada tipo)
        {
            float recaudado = 0;

            switch (tipo)
            {
                case ETipoLlamada.Local:


                    foreach (Llamada item in listaDeLlamadas)
                    {
                        if (item is Local)
                        {
                            recaudado += ((Local)item).CostoLlamada;
                        }

                    }
                    break;
                case ETipoLlamada.Provincial:

                    foreach (Llamada item in listaDeLlamadas)
                    {
                        if (item is Provincial)
                        {
                            recaudado += ((Provincial)item).CostoLlamada;
                        }

                    }
                    break;

                case ETipoLlamada.Todas:

                    foreach (Llamada item in listaDeLlamadas)
                    {
                        if (item is Local)
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

            sb.AppendLine($"Razón Social: {razonSocial}");
            sb.AppendLine($"Ganancia Total: {GananciasPorTotal}");
            sb.AppendLine($"Ganancia llam. Locales:  {GananciasPorLocal}");
            sb.AppendLine($"Ganancia llam. Provinciales: {GananciasPorProvincial}");

            foreach (Llamada item in listaDeLlamadas)
            {
                if (item is Local)
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
            return Mostrar();
        }
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada l1)
        {
            Llamadas.Add(l1);
        }

        /*El operador == retornará true si la
         * centralita contiene la llamada en su lista genérica. Utilizar la sobrecarga del operador == de la clase Llamada.*/
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool resultado = false;
            foreach (Llamada item in c.Llamadas)
            {
                if (item == llamada)
                {
                    resultado = true;
                }
            }
            return resultado;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        /*El operador + invocará al método AgregarLlamada sólo
         * si la llamada no está registrada en la Centralita. Utilizar la sobrecarga del operador == de Centralita.*/
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            return c;
        }



    }
}
