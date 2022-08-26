using System;

namespace _02Ej03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio I02 - ¿Desea continuar?
        Consigna
        Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

        Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

        El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.*/


            Console.WriteLine("SUMA DE NUMEROS ENTEROS:");
            
            bool digitoIngresado;
            int num1 = 0;
            int num2 = 0;
            bool respuestaDeseaSal;
            do
            {
                do
                {

                    Console.WriteLine($"Ingrese el primer número:");
                    string numString = Console.ReadLine();
                    digitoIngresado = int.TryParse(numString, out num1);
                    if (!digitoIngresado)
                    {
                        Console.WriteLine("Debe ingresar un número entero.");
                    }

                } while (!digitoIngresado);

                do
                {

                    Console.WriteLine($"Ingrese el segundo número:");
                    string numString = Console.ReadLine();
                    digitoIngresado = int.TryParse(numString, out num2);
                    if (!digitoIngresado)
                    {
                        Console.WriteLine("Debe ingresar un número entero.");
                    }

                } while (!digitoIngresado);

                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                Console.WriteLine("Desea salir? (S/N)");
                string stringDeseaSalir = Console.ReadLine();
                respuestaDeseaSal = Validador.ValidarRespuesta(stringDeseaSalir);



            } while (!respuestaDeseaSal);




        }
    }
}
