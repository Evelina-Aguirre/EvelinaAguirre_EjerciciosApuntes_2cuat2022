using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EjA01
{
    public class CalculaFactorial
    {
        public static int CalcularFactorial(int numero)
        {
            int resFactorial = 1;
            for (int i = 1; i <= numero; i++) 
            {
                resFactorial *= i;
            }


            return resFactorial;
        }
    }
}
