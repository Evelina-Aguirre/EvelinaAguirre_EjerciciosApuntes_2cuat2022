using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Ej3_ConversorBinario
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int entero)
        {

            string binario = "";
            int res;

            if (entero == 0)
                binario = "0";
            else
                while (entero > 0)
                {
                    res = entero % 2;
                    entero = entero / 2;
                    binario = Convert.ToString(res) + "" + binario;
                }
            return binario;

        }


        public static int ConvertirBinarioADecimal(string binario)
        {
            char[] array = binario.ToCharArray();
          
            Array.Reverse(array);
            int numDecimal = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // potencia de 2, según la posición
                    numDecimal += (int)Math.Pow(2, i);
                }
            }
            return numDecimal;
        }
    }
}
