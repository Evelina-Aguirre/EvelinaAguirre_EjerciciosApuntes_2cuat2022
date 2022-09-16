﻿using System;
using EjercicioIntegrador_PracticaPP;

namespace EjercicioIntegrador_PracticaPP_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Cliente mauri = new Cliente(ETipoCliente.PoliticoCorrupto,"Mauri");
            Cliente fariña = new Cliente(ETipoCliente.Financista, "Fariña");
            Cliente mesias = new Cliente(ETipoCliente.JugadorDeFutbol,
            "Lio");
            CuentaOffShore messiOff = new CuentaOffShore(mesias, 123, 15000);
            CuentaOffShore mauriOff = new CuentaOffShore(mauri, 678, 25000);
            CuentaOffShore lazaroOff = new CuentaOffShore("Lázaro",
            ETipoCliente.EmpresarioCorrupto, 456, 56000);
            CuentaOffShore otraDeMauri = new CuentaOffShore(mauri, 678,
            50000);
            CuentaOffShore fariOff = new CuentaOffShore(fariña, 666, 3500);
            ParaisoFiscal panamaPappers = eParaisosFiscales.Panamá;
            panamaPappers += messiOff;
            panamaPappers += mauriOff;
            panamaPappers += lazaroOff;
            panamaPappers.MostrarParaiso();
            panamaPappers += otraDeMauri;
            panamaPappers -= messiOff;
            panamaPappers -= fariOff;
            panamaPappers.MostrarParaiso();
            Console.ReadLine();
        }
    }
}
