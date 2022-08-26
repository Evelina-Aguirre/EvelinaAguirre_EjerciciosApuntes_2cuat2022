using System;

namespace Clase01_2C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2C 0_0
            int numero = 2;
            float numeroConComa;
            int[] array = new int[3];
            string palabra="7";
            bool flag = false;
            double doble = 20;

            numero = (int)doble;
            numero = int.Parse(palabra);
            doble = int.Parse(palabra);

            Console.WriteLine("Ingresar un número:");//imprimo
            palabra = Console.ReadLine();//levanto un dato
            Console.WriteLine(palabra);//imprimo

            for (int i = 0; i < palabra.Length; i++)//Lenght recorre el string palabra por char 
            {

            }
            //foreach (var item in collection)
            //{

            //}
            foreach (char item in palabra)
            {

            }



        


        }
    }
}
