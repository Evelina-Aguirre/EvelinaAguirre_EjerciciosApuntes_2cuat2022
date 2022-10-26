using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Torneo <T> where T : Equipo
    {
       private List<T> equipos;
        private string nombre;

        public Torneo(string nombre)
        {
            equipos = new List<T>();
            this.nombre = nombre;
        }
        public string JugarPartido
        {
            get
            {
                Random rnd = new Random();
                int indice1;
                int indice2;

                do
                {
                    indice1 = rnd.Next(equipos.Count);
                    indice2 = rnd.Next(equipos.Count);
                } while (indice1 == indice2);

                return CalcularPartido(this.equipos[indice1], this.equipos[indice2]);
            }
        }
        public static bool operator ==(Torneo<T>torneo, T equipo)
        {
            bool resultado = false;
            foreach (T item in torneo.equipos)
            {
                if(item == equipo) 
                {
                    resultado = true;
                }
            }
            return resultado;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
           
            if(torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random rnd = new Random();
            return $"{equipo1.Nombre} : {rnd.Next(0, 5)} – {equipo2.Nombre} : {rnd.Next(0, 5)}";

        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Torneo: {this.nombre}");
            foreach (var item in this.equipos)
            {
                sb.AppendLine($"{item.Ficha()}");
            }
            return sb.ToString();
        }

       
    }
}
