using System;
using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;


        public Equipo(string nombre)
        {
            this.nombre = nombre;
            this.fechaCreacion = DateTime.Now;
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public static bool operator == (Equipo e1, Equipo e2)
        {
            bool resultado = false;
            if(e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
            {
                resultado = true;
            }
            return resultado;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{nombre} fundado el {fechaCreacion}");

            return sb.ToString();
        }
    }
}
