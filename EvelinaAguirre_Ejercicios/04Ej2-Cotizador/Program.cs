using System;

namespace _04Ej2_Cotizador
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro billeteEuro = 1;
            Peso billeetePeso = (Peso)billeteEuro;
            Console.WriteLine("Conversión de $1 Euro a Peso: "+billeetePeso.GetCantidad); //142.18
            Dolar billeteDolar = 1;
            Peso billetePeso2 = (Peso)billeteDolar;
            Console.WriteLine("Conversión de $1 Dolar a Peso: " + billetePeso2.GetCantidad); //140.94


        }
    }
}
