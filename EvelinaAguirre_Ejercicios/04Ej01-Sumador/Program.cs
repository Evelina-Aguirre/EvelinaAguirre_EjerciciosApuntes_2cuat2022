using System;

namespace _04Ej01_Sumador
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio I01 - Sumador
            Consigna
            Crear un proyecto de tipo biblioteca de clases y agregar la clase Sumador.

            Diagrama de clase Sumador

            Crear dos constructores:

            Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
            Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
            El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:

            En el caso de Sumar(long, long) sumará los valores numéricos
            En el de Sumar(string, string) concatenará las cadenas de texto.
            Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.

            Seguido:

            Generar una conversión explícita que retorne cantidadSumas.

            Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.

            Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.

            Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.*/


            Sumador s1 = new Sumador(5);
            Sumador s2 = new Sumador(10);

            Console.WriteLine(s1.Sumar("cosa1", "cosa2"));
            Console.WriteLine(s1.Sumar(2, 2));

            Console.WriteLine("explicit, paso Sumador n1 a entero : "+ (int)s1);
            Console.WriteLine("Pipe, comparo Sumador n1 y n2: "+ (s1 | s2));
            Console.WriteLine("Sumo dos elementos de sumador: "+(s1 + s2));

        }
    }
}
