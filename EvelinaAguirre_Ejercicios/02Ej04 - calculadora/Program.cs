using System;

namespace _02Ej04___calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio I04 - La calculadora
        Consigna
        Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

        Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

        Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

        Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

        Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

        El usuario decidirá cuándo finalizar el programa.*/


            int operando1=0;
            int operando2 = 0;
            char operacion;
            bool resultadoOp1;
            bool resultadoOp2;
            bool resultadooperacionSeleccionada;

            do
            {
                Console.WriteLine("Ingrese el primer operando:");
                string numeroString1 = Console.ReadLine();
                resultadoOp1 = int.TryParse(numeroString1, out operando1);
            } while (!resultadoOp1);

            do
            {
                Console.WriteLine("Ingrese el segundo operando:");
                string numeroString2 = Console.ReadLine();
                resultadoOp2 = int.TryParse(numeroString2, out operando1);
            } while (!resultadoOp2);

            do
            {
                Console.WriteLine("Ingrese la operación a realizar '+' '-' '*' '/' :");
                string operacionString = Console.ReadLine();
                resultadooperacionSeleccionada = char.TryParse(operacionString, out operacion);
                if(operacion != '+' && operacion != '-' && operacion != '*' && operacion != '/')
                {
                    resultadooperacionSeleccionada = false;
                }

            } while (!resultadooperacionSeleccionada);

            float resultadoOperacion = Calculadora.Calcular(operando1, operando2, operacion);

            Console.WriteLine("El resultado de la operación es : {0}",resultadoOperacion);




        }
    }
}
