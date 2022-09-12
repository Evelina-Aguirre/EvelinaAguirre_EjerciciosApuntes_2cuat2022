using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Ej03_ElEjemploUniversal
{
    public class Estudiante
    {

        /*  Ejercicio I03 - El ejemplo universal
            Consigna
            Crear una aplicación de consola y una biblioteca de clases que contenga la clase del siguiente diagrama:

            Diagrama de clases

            La clase Estudiante:

            Tendrá un constructor estático que inicializará el atributo estático random.
             Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
            El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
            El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
            El método privado CalcularPromedio retornará el promedio de las dos notas.
            El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
            El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
            Nombre, apellido y legajo.
            Nota del primer y segundo parcial.
            Promedio.
            Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
            Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
            Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
            Mostrar los datos de todos los alumnos.
            IMPORTANTE
            Para darle un valor aleatorio a la nota final utilice el método de instancia Next de la clase Random.*/

        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public int SetNotraPrimerParcial
        {
            set
            {
                this.notaPrimerParcial = value;
            }
        }

        public int SetNotaSegundoParcial
        {
            set
            {
                this.notaSegundoParcial = value;
            }
        }

        private float CalcularPromedio(int nota1, int nota2)
        {
            return (nota1 + nota2) / 2;
        }

        private double NotaFinal()
        {
            double notaFinal=-1;
            if(this.notaPrimerParcial >=4 && this.notaSegundoParcial >=4)
            {
                notaFinal = Estudiante.random.Next(6, 11);
            }
            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.nombre} / {this.apellido} / {this.legajo}");
            sb.AppendLine($"Notas :  1erP - {this.notaPrimerParcial} / 2doP {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio : {this.CalcularPromedio(this.notaPrimerParcial, this.notaSegundoParcial)}");
            
            if (this.NotaFinal() != -1)
            {
                sb.AppendLine($"Nota final : { this.NotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumn@ desaprobad@");
            }

            return sb.ToString();
        }
    }
}
