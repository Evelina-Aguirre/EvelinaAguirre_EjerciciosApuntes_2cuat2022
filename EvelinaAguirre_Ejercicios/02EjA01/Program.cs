using System;

namespace _02EjA01
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio A01 - Calcular un factorial
            Consigna
            El factorial de un número es una operación que consiste en multiplicar un numero “n” 
            por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial 
            de 3 es el resultado de multiplicar 3 por 2 por 1.

            En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
             */


            bool respuesta;
            int num = 0;

            do {
                Console.WriteLine("Ingrese un número");
                string stringNumero = Console.ReadLine();
                respuesta = int.TryParse(stringNumero, out num);

                if(!respuesta)
                {
                    Console.WriteLine("Para operar ingrese un número entero.");
                }

            } while (!respuesta);



             Console.WriteLine($"\nEl Factorial es: {CalculaFactorial.CalcularFactorial(num)}");

            

        }
    }
}
