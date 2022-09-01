using System;

namespace _03Ej2_cuantasPrimaverasTenes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio I02 - ¿Vos cuántas primaveras tenés?
            Consigna
            Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

            Deberá tener los atributos:

            nombre
            fechaDeNacimiento
            dni
            Deberá tener un constructor que inicialice todos los atributos.

            Construir los siguientes métodos para la clase:

            Setter y getter para cada uno de los atributos.
            CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
            Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
            EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
            Instanciar 3 objetos de tipo Persona en el método Main.
            Mostrar quiénes son mayores de edad y quiénes no.*/

            Persona persona1 = new Persona("Maria",new DateTime(1970,04,21),10243725);
            Persona persona2 = new Persona("Juan", new DateTime(2002,06,14), 40311920);
            Persona persona3 = new Persona("Crisalida",new DateTime(2018,02,01), 55755425);

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad(persona1.FechaDeNacimiento));

            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad(persona2.FechaDeNacimiento));

            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad(persona3.FechaDeNacimiento));

        }
    }
}
