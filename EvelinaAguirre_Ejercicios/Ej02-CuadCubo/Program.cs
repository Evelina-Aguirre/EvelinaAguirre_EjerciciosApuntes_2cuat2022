using System;

namespace Ej02_CuadCubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio I02 - Error al cubo
            Consigna
            Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
            Se debe validar que el número sea mayor que cero, caso contrario, 
            mostrar el mensaje: "ERROR. ¡Reingresar número!".

            IMPORTANTE
            Utilizar el método Pow de la clase Math para calcular las potencias.*/

           
            bool resultado = false;
            int numero=0;


            while (!resultado)
            {
                Console.WriteLine("Ingrese un número:");
                string numeroIngresadoString = Console.ReadLine();
                resultado= int.TryParse(numeroIngresadoString, out numero);
               
                if(numero<=0 || resultado == false)
                {
                    resultado = false;
                    //se agrega esta validación siendo que si ingresa 0, el parse pasa a TRUE porque 
                    //pudo transformar el string ingresado en un número. 
                    Console.WriteLine("Debe Ingresar un número entero mayor que 0\n");
                }

            }

            double cuadrado = Math.Pow(numero,2);
            double cubo = Math.Pow(numero,3);

            Console.WriteLine("El cuadrado del número ingresado es: {0}",cuadrado);
            Console.WriteLine("El cubo del número ingresado es: {0}", cubo);




        }
    }
}
