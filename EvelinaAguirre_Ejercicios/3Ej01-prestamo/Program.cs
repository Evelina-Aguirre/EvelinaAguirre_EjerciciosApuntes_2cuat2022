using System;
using _03Ej3_EntidadesPrestamo;

namespace _3Ej01_prestamo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio I01 - Creo que necesito un préstamo
            Consigna
            Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

            Deberá tener los atributos:

            titular que contendrá la razón social del titular de la cuenta.
            cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
            Construir los siguientes métodos para la clase:

            Un constructor que permita inicializar todos los atributos.
            Un método getter para cada atributo.
            mostrar retornará una cadena de texto con todos los datos de la cuenta.
            ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
            retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
            
            f- En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.*/

            Cuenta cuenta1 = new Cuenta("Pedro", 1000000);

            cuenta1.Mostrar();

            
            int opcion;
            bool resultado=false;
            do
            {
                Console.WriteLine("***************\n");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - acreditar");
                Console.WriteLine("2 - debitar");
                Console.WriteLine("3 - salir\n");
                Console.WriteLine("***************\n");
                string opcionString =Console.ReadLine();
                resultado = int.TryParse(opcionString, out opcion);
                if(!resultado)
                {
                    Console.WriteLine("Lo ingresado no es una opción válida.\n");
                }
            } while (!resultado);

            bool resultadoMontoIngresado=false;
            decimal montoAcreditar;


            switch (opcion)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("Ingrese monto que desea acreditar:");
                        string montoString = Console.ReadLine();
                        resultadoMontoIngresado = decimal.TryParse(montoString, out montoAcreditar);

                        if (!resultadoMontoIngresado)
                        {
                            Console.WriteLine("ERROR!- El monto a acreditar debe ser un valor mayor que cero.");
                        }
                    } while (!resultadoMontoIngresado);

                    cuenta1.cantidadActualCuenta = cuenta1.Ingresar(montoAcreditar);
                    cuenta1.Mostrar();

                    break;

                case 2:
                    do
                    {
                        Console.WriteLine("Ingrese monto que desea retirar:");
                        string montoString = Console.ReadLine();
                        resultadoMontoIngresado = decimal.TryParse(montoString, out montoAcreditar);

                        if (!resultadoMontoIngresado)
                        {
                            Console.WriteLine("ERROR!- El monto no es válido.");
                        }
                    } while (!resultadoMontoIngresado);

                    cuenta1.cantidadActualCuenta =cuenta1.Retirar(montoAcreditar);
                    cuenta1.Mostrar();

                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("La opción ingresada no es válida");
                    break;
            }
            
                
            
                
                
            
        

           

         

        }
    }
}
