using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apuntes02
{
    internal class ClassPrueba  //--> Original internal class ClassPrueba.. le pongo que es estático para poder usarlo sin necesidad de instanciar  
    {
        //public void Leer() // Método de instancia , si no tiene static, se puede hacer "new ClassPrueba".
        //{

        //}

        //public: se ve desde cualquier parte.
        //private: se va a ver dentro de la misma clase , es algo interno que lo va a ver la misma clase
        //Protected: va a sr visible como privado, dentro de la misma clase y dentro de las clases derivada de esta.
        //Internal: Es solo accesible dentro del mismo proyecto, si hacemos librerías podemos querer encapcular clases que sean para trabajo internal.
        //Si no tenemos nada va a ser ..

        //Si es ESTÁTICO no se puede instanciar.. no es común llamar static a la clase si a los métodos 
        static public void LeerEstatico() // Si dice static se dice que es de clase, lo que significa que puedo acceder desde la clase sin necesidad de instanciar
        {



        }


        // - Si la clase es estática va a pedir que todos los métodos sean státicos.
        //- Si la clase no es estático puede haber estático y de instancia (que no diga estático y se puede hace run individuo del molde gral.)
    }
}