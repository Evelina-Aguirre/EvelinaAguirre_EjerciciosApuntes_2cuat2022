using System;

namespace _02Ej3_ConversorBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero decimal");
            int numero = Convert.ToInt32(Console.ReadLine());

            string binario = Conversor.ConvertirDecimalABinario(numero);
            Console.WriteLine("El numero decimal " + numero + " en binario es " + binario);

            int decimalB = Conversor.ConvertirBinarioADecimal(binario);
            Console.WriteLine("El numero binario " + binario + " en decimal es " + decimalB);

        }
    }
}
