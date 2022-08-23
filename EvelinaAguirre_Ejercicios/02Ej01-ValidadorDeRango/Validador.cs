using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Ej01_ValidadorDeRango
{
   public static class Validador
    {
   
        public static bool Validar(int valor, int min, int max) 
        {
            if(valor < min || valor > max)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
