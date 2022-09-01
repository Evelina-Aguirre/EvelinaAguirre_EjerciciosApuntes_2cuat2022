using System;

namespace _03Ej03_ElEjemploUniversal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio I03 - El ejemplo universal
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


            Estudiante a1 = new Estudiante("Francisco", "Carmelo", "109825");
            Estudiante a2 = new Estudiante("Milena", "Acasia", "109814");
            Estudiante a3 = new Estudiante("Lara", "Ramirez", "109833");

            a1.SetNotraPrimerParcial = 9;
            a1.SetNotaSegundoParcial = 6;

            a2.SetNotraPrimerParcial = 4;
            a2.SetNotaSegundoParcial = 2;

            a3.SetNotraPrimerParcial = 10;
            a3.SetNotaSegundoParcial = 4;

            Console.WriteLine(a1.Mostrar());
            Console.WriteLine(a2.Mostrar());
            Console.WriteLine(a3.Mostrar());
        }
    }
}
