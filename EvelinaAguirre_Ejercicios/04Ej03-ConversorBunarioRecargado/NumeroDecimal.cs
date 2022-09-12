using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Ej03_ConversorBunarioRecargado
{
    public class NumeroDecimal
    {
        private double numero;
        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double Numero
        {
            get
            {
                return this.numero;
            }
        }

        public string ConvertirDecimalABinario(double entero)
        {

            string binario = "";
            double res;

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


        public static implicit operator NumeroDecimal(double d)
        {
            return new NumeroDecimal(d);
        }

        public static explicit operator double(NumeroDecimal d)
        {
            return d.Numero;
        }

        public static explicit operator NumeroBinario(NumeroDecimal d)
        {
            return d.ConvertirDecimalABinario(d.Numero);
        }

        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            return d.Numero == ((NumeroDecimal)b).Numero;
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return !(d==b);
        }

        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            return d.Numero + ((NumeroDecimal)b).Numero;
        }

        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            return d.Numero - ((NumeroDecimal)b).Numero;
        }



    }
}
