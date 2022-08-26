using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EjPlus_Atributos
{
    public class Sello
    {
        public static string mensaje; //Atributo..variable de la clase
        public static ConsoleColor color;

        public static string Imprimir()
        {

            return Sello.ArmarFormatoMensaje();
        }

        public static string Borrar()
        {
            return Sello.mensaje = string.Empty;
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

        private static string ArmarFormatoMensaje()
        {
          
            for (int i = 0; i < Sello.mensaje.Length +2; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("\n*"+ Sello.mensaje+"*");

            for (int i = 0; i < Sello.mensaje.Length +2 ; i++)
            {
                Console.Write("*");
               
            }

         return "";

        }






    }
}
