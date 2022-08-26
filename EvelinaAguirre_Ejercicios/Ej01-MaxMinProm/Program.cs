using System;

namespace Ej01_MaxMinProm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio I01 - Máximo, mínimo y promedio
            Consigna
            Ingresar 5 números por consola, guardándolos en una variable escalar. 
            Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            INFORMACIÓN
             Un escalar es una constante o variable que contiene un dato atómico y unidimensional. 
             En contraposición al concepto de escalar, están los conceptos de array, lista y objeto, 
            que pueden tener almacenado en su estructura más de un valor.​*/

            int numero = 0;
            int acum = 0;
            int max = int.MinValue;//le asigno al máximo el menos número posible para después igualarlo a lo que sea que ingrese 
            int min = int.MaxValue;//Mismo que max, le asigno el mayor número posible 
            double promedio;
            bool resultado;

            Console.WriteLine("Por favor Ingrese cinco números... \n");

            string [] arrayPosiciónNumAIngresar = { "primer", "segundo", "tercer", "cuarto", "quinto" };

            for (int i = 0; i < 5; i++)
            {

                do
                {
                    Console.WriteLine($"Ingrese el {arrayPosiciónNumAIngresar[i]} número :");
                    string numString = Console.ReadLine();
                    resultado = int.TryParse(numString, out numero);
                    
                    if (!resultado)
                    {
                        Console.WriteLine("Debe ingresar un número entero: ");
                    }

                } while (!resultado);


                if (numero > max)
                {
                    max = numero;
                }
                if (numero < min)
                {
                    min = numero;
                }

                acum = numero + numero;
            }

            promedio = acum / 5;

            Console.WriteLine($"Máínimo : {min}");
            Console.WriteLine($"Máximo : {max}");
            Console.WriteLine($"Promedio : {promedio}");
        }
    }
}
