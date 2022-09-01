using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Ej2_cuantasPrimaverasTenes
{
    public class Persona
    {
        /*
             Ejercicio I02 - ¿Vos cuántas primaveras tenés?
            Consigna
            Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

            Deberá tener los atributos:

            nombrex
            fechaDeNacimientox
            dnix

            Deberá tener un constructor que inicialice todos los atributos.x

            Construir los siguientes métodos para la clase:

            Setter y getter para cada uno de los atributos.x
            CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.x
            Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.x
            EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.x
            Instanciar 3 objetos de tipo Persona en el método Main.
            Mostrar quiénes son mayores de edad y quiénes no.*/

        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;
        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.Nombre = nombre;
            this.FechaDeNacimiento = fechaDeNacimiento;
            this.Dni = dni;
                
        }

        //No tiene sentido ponerlos privados y hacer getter y setter públicos.. but el ejercico lo pide
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public int Dni { get => dni; set => dni = value; }

        private int CalcularEdad(DateTime fechaDeNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int calculoEdad = 0;
            if (fechaDeNacimiento < fechaActual)
            {
                calculoEdad = fechaActual.Year - fechaDeNacimiento.Year;
            }
            if (fechaDeNacimiento.Month > fechaActual.Month)
            {
                calculoEdad--;
            }
            return calculoEdad;
        
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*************************");
            sb.AppendLine($"{this.nombre}");
            sb.AppendLine($"{CalcularEdad(this.fechaDeNacimiento)}");
            sb.AppendLine($"{this.dni}");
            sb.AppendLine("*************************");
            return sb.ToString();
        }


        //En appendline no poner \n -- tampoco hace falta poner {cantidad.ToString()} se puede pero en appendLine no da error
        //en los métodos no meter dos returns

        public string EsMayorDeEdad(DateTime fechaNacimiento)
        {
            StringBuilder sb = new StringBuilder();
            if(CalcularEdad(fechaNacimiento) >= 18)
            {
                sb.AppendLine("Es mayor de edad.");
            }
            else
            {
                sb.AppendLine("Es menor");
            }
            return sb.ToString();

        }

    }
}
