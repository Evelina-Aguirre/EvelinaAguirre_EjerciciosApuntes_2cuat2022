using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioIntegrador_PracticaPP
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividades;

        static ParaisoFiscal()
        {
            ParaisoFiscal.cantidadDeCuentas = 0;
            ParaisoFiscal.fechaInicioActividades = DateTime.Now;
        }
        private ParaisoFiscal()
        {
            _listadoCuentas = new List<CuentaOffShore>();
        }
        private ParaisoFiscal(eParaisosFiscales lugar) : this()
        {
            _lugar = lugar;
        }



        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            return new ParaisoFiscal(epf);
        }

        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool retorno = false;
            if (pf is not null && pf is not null)
            {
                foreach (CuentaOffShore item in pf._listadoCuentas)
                {
                    if (cos == item)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }

        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (pf is not null && pf is not null)
            {
                if (pf == cos)
                {
                    pf._listadoCuentas.Remove(cos);
                    ParaisoFiscal.cantidadDeCuentas--;
                    Console.WriteLine("Se quitó la cuenta del paraíso...");
                }
                else
                {
                    Console.WriteLine("La cuenta no existe en el paríso...");
                }

            }
            return pf;
        }

        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool retorno = false;

            if (pf is not null && pf is not null)
            {
                if (pf != cos)
                {
                    pf._listadoCuentas.Add(cos);
                    ParaisoFiscal.cantidadDeCuentas++;
                    Console.WriteLine("Se agregó la cuenta al paraíso...");
                }
                else
                {

                    foreach (CuentaOffShore item in pf._listadoCuentas)
                    {
                        if (pf == item)
                        {
                            item.Saldo += cos.Saldo;
                            Console.WriteLine("Se actualizó el saldo de la cuenta...");
                        }

                        retorno = true;

                    }
                }

            }
            return pf;

        }

        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fecha de Inicio: {ParaisoFiscal.fechaInicioActividades}");
            sb.AppendLine($"Lugar de Radicación:{ _lugar}");
            sb.AppendLine($"Cantidad de Cuentas:{ParaisoFiscal.cantidadDeCuentas}");
            sb.AppendLine($"*****************************************");

            foreach (CuentaOffShore item in _listadoCuentas)
            {
                sb.AppendLine(Cliente.RetornarDatos(item.Dueño));
                sb.AppendLine($"Numero de cuentas:{(int)item}");
                sb.AppendLine($"Saldo{item.Saldo}");
            }
            Console.WriteLine(sb.ToString());

        }


    }
}
