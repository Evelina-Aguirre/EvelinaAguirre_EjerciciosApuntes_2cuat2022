using System;
using Apuntes02;//Agregue al proyecto Apuntes02 que contiene la Class que cree de prueba 
using IOFile = System.IO.File; //<---- así hago un aliás, para no tener que escribir todo, es una opción nada más (A*)

namespace Apuntes02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            NAMESPACE: Agrupación lógica de clases, para que el programa sea más ordenado. 
            (x ej,. varias clases con el mismo nombre en el mismo namespace)

            - tiene dentro el program, clases, archivos...
            - Console x ej. es una clase de System , system es el namespace.  
            - Se pueden tener todos los namespace q se quieran y repetir el nombre de la clase
            - El programa tiene un solo punto de inicio que es el Main


             */
            //*creo ClassPrueba en este namespace con un método de instancia*
            //ClassPrueba prueba = new ClassPrueba(); -->Lo instanciaría así para crear un obj de esa clase.

            // IOFile.WriteAllText...  <-- y así uso el alias. (A* hice el alias en los using de acá arriba)



            // - Métodos empiezan con mayuscula, tienen que ser verbos ... todos los nombres tienen que ser descriptivo
            //-Namespece también con myus no tiene que ser un verbo


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //ClassPrueba.LeerEstatico(); // Método de clase no hace falta instanciar para usarlo


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //STATIC : Hay uno solo en todo el programa y se comparte 
            //métodos --> deben ser verbos + capaz si es contar qué cuenta. (Método Pascal.. primera de cada palabra en mayus)
            //tamaño de anidamiento 20 lineas como mucho
            //si está anidado separar en más métodos


            //LLAMO AL METODO STATICO CREADO EN LA CLASE
            string texto;
            texto = ClassPrueba.EscribirNotas();
            Console.WriteLine(texto);








        }
    }
}
