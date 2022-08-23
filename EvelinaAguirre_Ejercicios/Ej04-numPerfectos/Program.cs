using System;

namespace Ej04_numPerfectos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio I04 - Un número perfecto
            Consigna
            Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros 
            positivos (excluido el mismo) que son divisores del número.

            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

            Escribir una aplicación que encuentre los 4 primeros números perfectos.

            IMPORTANTE
            Utilizar sentencias de iteración y selectivas.*/
            int acumuladoNumerosDivisores=0;

            for (int numQueSeEstaEvaluando = 2; numQueSeEstaEvaluando < 50; numQueSeEstaEvaluando++) //itero hasta 500 siendo que el 4to perfecto es 486
            {
                for (int j = 2; j <= numQueSeEstaEvaluando; j++) //Itero hasta el número que se está evaluando actualmente para saber si este es un núm perfecto
                {
                    if(numQueSeEstaEvaluando % j  ==0) 
                    {
                        acumuladoNumerosDivisores += j;
                    }
                }
                if(acumuladoNumerosDivisores == numQueSeEstaEvaluando)
                {
                    Console.WriteLine($"{numQueSeEstaEvaluando} Es un número perfecto");
                }
                acumuladoNumerosDivisores = 0;
            }




        }
    }
}
