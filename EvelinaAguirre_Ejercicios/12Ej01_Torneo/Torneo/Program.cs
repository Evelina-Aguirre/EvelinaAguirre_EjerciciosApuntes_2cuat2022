using System;
using Entidades;

namespace Torneo
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFubtol = new Torneo<EquipoFutbol>("Torneo de futbol");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo de basquet");

            EquipoFutbol boca = new EquipoFutbol("boca");
            EquipoFutbol noBoca = new EquipoFutbol("noBoca");


            EquipoBasquet altura = new EquipoBasquet("altura");
            EquipoBasquet mismaAltura = new EquipoBasquet("mismaAltura");

            torneoFubtol += boca;
            torneoFubtol += noBoca;

            torneoBasquet += altura;
            torneoBasquet += mismaAltura;

            Console.WriteLine(torneoFubtol.Mostrar());
            Console.WriteLine(torneoFubtol.JugarPartido);
            Console.WriteLine(torneoFubtol.JugarPartido);

            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
        }
    }
}
