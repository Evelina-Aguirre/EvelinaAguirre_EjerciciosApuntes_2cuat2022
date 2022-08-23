using System;

namespace Ej03_Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio I03 - Los primos
            Consigna
            Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

            Validar que el dato ingresado por el usuario sea un número.

            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

            Si ingresa "salir", cerrar la consola.

            Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

            IMPORTANTE
            Utilizar sentencias de iteración, selectivas y el operador módulo (%).*/

            bool resultado = false;
            int numero = 0;
            bool esPrimo = false;

            while(!resultado)
            {
                Console.WriteLine("Ingrese un número:");
                string numeroString = Console.ReadLine();
                resultado = int.TryParse(numeroString, out numero);
               
                if (numero <= 0 || resultado == false)
                {
                    resultado = false;
                    Console.WriteLine("Debe Ingresar un número entero mayor que 0\n");
                }

            }

            

            //for (int i = 2; i <= numero; i++)
            //{
            //    if (numero % (numero + 1) == 0) //Si es divisible por (sí mismo +1) deja de ser primo
            //    { 
            //        esPrimo = false;
            //        Console.WriteLine($"{numero} no es");
            //    }

            //    if(numero % i ==0)
            //    {
            //        esPrimo = false;
            //        Console.WriteLine($"{i} no es");
            //    }
            //    else
            //    {
            //        esPrimo = true;
            //        Console.WriteLine($"{i} es Primo");
            //    } 
            //}

            
           
            

            
        }
    }
}
