using System;

namespace Clase01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //control k+d ordenar código



            //string nombre;

            //nombre = Console.ReadLine();
            //Console.WriteLine(nombre); //imprime dato pre ingresado en la variable */

            //nombre = "Eve";

            //Console.WriteLine("Hola {0} Ingresá tu edad : ", nombre);
            //string edadIngresada = Console.ReadLine();

            //int edad;
            //bool resultado = int.TryParse(edadIngresada,out edad);  //Toma edadIngresada si la puede convertir guarda en el bool el true sino el false.


            //if(resultado)
            //{

            //    Console.WriteLine("Hola {0}!, tu edad es {1}",nombre, edad, Environment.NewLine);
            //}
            //else
            //{

            //    Console.WriteLine("Hola {0}!,{2} No se pudo registrar tu edad"
            //        , nombre, edad, Environment.NewLine); //El enviroment new Line ingresa un salto de linea...
            //                                             //y "tu edad" aparece abajo.. Enviromente toma en este caso la pos. {2} 
            //}


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //FLOAT


            ////Console.WriteLine("Se pudo convertir: {0}", resultado);

            //float precio = 45.75f; //Si no especifico la f me da un error de compilación

            //Console.WriteLine("INGRESE PRECIO:");
            //string precioIngresado = Console.ReadLine();
            //float precio;
            //bool resultado = float.TryParse(precioIngresado, out precio);
            //Console.WriteLine($"El precio SIN C2 es: {precio}");
            //Console.WriteLine($"El precio CON C2 es : {precio:C2}");
            //Console.ReadLine();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //DOUBLE


            //float precio = 12.5f;
            //double precio2 = 52.1; //double no garantiza precisión no hace falta aclarar la "f" al final

            //double a = 0.1;
            //double b = 0.2;

            //double sumaABResultado = a + b;
            //double resultadoEsperado = 0.3;

            //Console.WriteLine($"resultado : {sumaABResultado}, resultado esperado {resultadoEsperado}"); //dá 0.3000000000000004 hiper impreciso es más preciso DECIMAL




            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //DECIMAL


            //decimal a = 0.1M; //---> Para setear un decimal hay que aclararle M al final
            //decimal b = 0.2M;

            //decimal sumaABResultado = a + b;
            //decimal resultadoEsperado = 0.3M;

            //Console.WriteLine($"resultado : {sumaABResultado}, resultado esperado {resultadoEsperado}"); //da exacto 0.3


            //var edad = 15; --> CUALQUIER DATO no está bueno porque es más facil leer código cuando está fuertemente
            //tipado (especificar si es int float etc)

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //CONVERSIÓN EXPLÍCITA



            //float precioComa = 12.20f;
            //int precioSinComa = precioComa;  (No me deja) float es más grande que un número entero.. hay que castearlo convertir un tipo de dato en otro
            //int precioSinComa = (int)precioComa; //Ahí está casteado ----> se llama COVERSIÓN EXPLÍCITA.. PUEDE IMPLICAR PERDIDA DE INFO 




            //CONVERSIÓN IMPLÍCITA



            //int precioEntero = 125;
            //float precioFloat = precioEntero;

            //PARSEO : Solo para string
            //CASTEO : Para daros numéricos


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            // _ = int.TryParse("15", out int numero); --> Este guión bajo funciona pero es un dato booleano que no necesito para nada,
            // nada más para que funcione, no se puede recuperar info de _


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //ARRAYS



            //Tienen tamaño FIJO

            //string[] nombres = new string[5];

            //nombres[0] = "lala";
            //nombres[1] = "lila";
            //nombres[2] = "lola";

            //for (int i = 0; i < nombres.Length; i++)
            //{
            //    Console.WriteLine(nombres[i]);
            //}

            //string[] paises = { "Cuba", "Dinamarca", "Holanda" };

            //for (int i = 0; i <paises.Length; i++)
            //{
            //    Console.WriteLine(paises[i]);

            //}



            //FOREACH


            //foreach (var item in paises)
            //{
            //  Console.WriteLine(item);
            //}

            //foreach (string pais in paises)
            //{
            //    Console.WriteLine(pais);
            //}
        }
    }
}
