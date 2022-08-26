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

            bool resultado;
            bool salir;
            int numero = 0;
            int cantidadFueDivisible=0;
            //bool esPrimo = false;

            do
            {
                Console.WriteLine("Ingrese un número o 'S' para salir:");
                string numeroString = Console.ReadLine();
                numeroString.ToLower();
                
                if(numeroString == "s")
                {
                    Environment.Exit(0);
                }

                resultado = int.TryParse(numeroString, out numero);

                if (numero <= 0 || resultado == false)
                {
                    resultado = false;
                    Console.WriteLine("Debe Ingresar un número entero mayor que 0.\n)");
                }

            } while (!resultado);


            for (int j = 2; j <=numero; j++) //Itero desde 2 hasta el numero ingresado inclusive (el uno no se tomá más como primo)
            {


                for (int i = 1; i <= j; i++) //Itero desde uno hasta el número que se está evaluando actualmente 
                {
                    if (j % i == 0)
                    {
                        cantidadFueDivisible += 1; 
                    }
                }

                if (cantidadFueDivisible == 2 || j==1) //si fue divisible por 1 o por él mismo es Primo 
                {
                    //esPrimo = true;
                    Console.WriteLine($"{j} Es primo");
                }
               
                cantidadFueDivisible = 0; //reseteo el contador de cuántas veces fue divisible para el prox. loop

            }



        }
    }
}
