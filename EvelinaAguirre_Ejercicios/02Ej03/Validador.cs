using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Ej03
{
    internal class Validador
    {
        /// <summary>
        /// valida que el carácter ingresado sea solo la letra 'S'
        /// </summary>
        /// <param name="respuesta"></param>
        /// <returns></returns>
        public static bool ValidarRespuesta(string respuesta)
        {
            respuesta.ToLower();
            if ( respuesta == "s")
            {
                return true;
            }
            return false;
        }
    }
}
