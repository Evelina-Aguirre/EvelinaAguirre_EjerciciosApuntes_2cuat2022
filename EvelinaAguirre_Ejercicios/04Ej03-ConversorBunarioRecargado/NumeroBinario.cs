using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Ej03_ConversorBunarioRecargado
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string Numero
        {
            get
            {
                return this.numero;
            }
        }


        public int ConvertirBinarioADecimal(string binario)
        {
            char[] array = binario.ToCharArray();
            // Invertido, los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);
            int numDecimal = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                   
                    numDecimal += (int)Math.Pow(2, i);
                }
            }
            return numDecimal;
        }


        public static implicit operator NumeroBinario(string b)
        {
            return new NumeroBinario(b);
        }

        public static explicit operator string(NumeroBinario b)
        {
            return b.Numero;
        }

        public static explicit operator NumeroDecimal(NumeroBinario b)
        {
            return b.ConvertirBinarioADecimal(b.Numero);
        }

        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return (b.Numero == ((NumeroBinario)d).Numero);
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }

        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            return d.ConvertirDecimalABinario(((NumeroDecimal)b).Numero + d.Numero);
        }

        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            return d.ConvertirDecimalABinario(((NumeroDecimal)b).Numero - d.Numero);
        }






    }
}
