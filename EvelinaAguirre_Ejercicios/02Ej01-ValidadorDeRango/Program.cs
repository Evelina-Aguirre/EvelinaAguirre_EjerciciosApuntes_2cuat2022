using System;

namespace _02Ej01_ValidadorDeRango
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio I01 - Validador de rangos
            Consigna
            Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

            bool Validar(int valor, int min, int max)

            valor: dato a validar.
            min: mínimo valor incluido.
            max: máximo valor incluido.
            Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente 
            que estén dentro del rango -100 y 100.

            Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
             
             */

            
            
            Console.WriteLine("Debe ingresar 10 números enteros entre -100 y 100. ");

            string[] pocisión = { "primer", "segundo", "tercer", "cuarto", "quinto", "sexto", "seprimo", "octavo", "noveno", "decimo" };

            int numero;
            int min = int.MaxValue;
            int max = int.MinValue;
            int acum = 0;
            float promedio;


            bool estaDentroDeParametros;

            for (int i = 0; i < 10; i++)
            {


                Console.WriteLine($"Ingrese el {pocisión[i]} número entre -100 y 100:");
                string numeroString = Console.ReadLine();
                bool resultado = int.TryParse(numeroString, out numero);

                while (!resultado)
                {
                    Console.WriteLine("Debe ingresar un valor numérico");
                    numeroString = Console.ReadLine();
                    resultado = int.TryParse(numeroString, out numero);
                }


                estaDentroDeParametros = Validador.Validar(numero, -100, 100);


                while (!estaDentroDeParametros)
                {
                    Console.WriteLine("Debe ingresar un número entero entre -100 y 100");
                    numeroString = Console.ReadLine();
                    resultado = int.TryParse(numeroString, out numero);
                    estaDentroDeParametros = Validador.Validar(numero, -100, 100);
                }

                if (numero > max)
                {
                    max = numero;
                }
                if (numero < min)
                {
                    min = numero;
                }

                acum += numero;


            }

            promedio = acum / 10;

            Console.WriteLine("Min : {0}", min);
            Console.WriteLine("Max. : {0}", max);
            Console.WriteLine("Pormedio : {0}", promedio);



        }
    }
}
