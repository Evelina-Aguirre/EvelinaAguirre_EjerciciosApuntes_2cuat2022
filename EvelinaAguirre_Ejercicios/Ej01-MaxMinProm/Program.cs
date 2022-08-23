using System;

namespace Ej01_MaxMinProm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio I01 - Máximo, mínimo y promedio
            Consigna
            Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            INFORMACIÓN
             Un escalar es una constante o variable que contiene un dato atómico y unidimensional. 
             En contraposición al concepto de escalar, están los conceptos de array, lista y objeto, 
            que pueden tener almacenado en su estructura más de un valor.​*/

            int acum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            double promedio;

            Console.WriteLine("Por favor Ingrese cinco números... \n");

            string [] arrayPosiciónNumAIngresar = { "primer", "segundo", "tercer", "cuarto", "quinto" };

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"Ingrese el {arrayPosiciónNumAIngresar[i]} número :");
                string numString = Console.ReadLine();
                int numero = 0;
                bool resultado = int.TryParse(numString, out numero);

                while (!resultado)
                {
                    Console.WriteLine("Debe ingresar un número entero: ");
                    numString = Console.ReadLine();
                    resultado = int.TryParse(numString, out numero);

                }


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
