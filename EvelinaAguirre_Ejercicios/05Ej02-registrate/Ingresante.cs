using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Ej02_registrate
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string [] cursos,int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre:{this.nombre}");
            sb.AppendLine($"Dirección:{this.direccion}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"País:{this.pais}");
            sb.AppendLine($"Cursos:");
            foreach (string item in this.cursos)
            {
                if(item != null)
                sb.AppendLine($"{item}");
            }
            
            sb.AppendLine($"Edad:{this.edad}");

            return sb.ToString();
        }


    }
}
