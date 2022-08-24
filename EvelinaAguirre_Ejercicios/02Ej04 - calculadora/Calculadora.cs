using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Ej04___calculadora
{
    internal class Calculadora
    {
        /*
         
        Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. 
        El método devolverá el resultado de la operación.*/

        public static float Calcular (int operando1,int operando2, char operacion )
        {
            if(operacion == '+')
            {
                return operando1 + operando2;
            }
            else if (operacion == '-')
            {
                return operando1 - operando2;
            }
            else if (operacion == '*')
            {
                return operando1 * operando2;
            }
            else if (operacion == '/')
            {
                if(Validar(operando2))
                {
                    return operando1 / operando2;
                }else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

            
        }

        /*Validar (privado): Recibirá como parámetro el segundo operando. 
        Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
        Este método devolverá true si el operando es distinto de cero.
*/
        private static bool Validar(int operando2)
        {
            if(operando2> 0)
            {
                return true;
            }
            return false;
        }



    }
}
