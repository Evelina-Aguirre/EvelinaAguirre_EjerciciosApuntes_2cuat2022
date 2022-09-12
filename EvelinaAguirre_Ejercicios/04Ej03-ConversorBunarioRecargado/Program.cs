using System;

namespace _04Ej03_ConversorBunarioRecargado
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;

            string binario = (string)objBinario;
            double numeroDecimal = (double)objDecimal;

            double suma = objDecimal + objBinario;
            double resta = objDecimal - objBinario;

            Console.WriteLine("El numero binario {0}, sumado al numero decimal {1} es {2}", binario, numeroDecimal, suma);
            Console.WriteLine("El numero binario {0}, restado al numero decimal {1} es {2}", binario, numeroDecimal, resta);
        }
    }
}
