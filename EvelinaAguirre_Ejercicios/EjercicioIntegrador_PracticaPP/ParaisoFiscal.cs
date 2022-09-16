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
            return new ParaisoFiscal(epf);//Tiene que retornar Ejemplo: ParaisoFiscal pf = eParaisosFiscales.Panamá;
        }

        public static bool operator ==(ParaisoFiscal pf,CuentaOffShore cos)
        {
            bool retorno = false;
            if(pf is not null && pf is not null)
            {
                foreach (CuentaOffShore item in pf._listadoCuentas)
                {
                    if(cos.Dueño.GetAlias() == item.Dueño.GetAlias())
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf != cos);
        }

        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool retorno = false;
            if (pf is not null && pf is not null)
            {
                foreach (CuentaOffShore item in pf._listadoCuentas)
                {
                    if (pf == item)
                    {
                        pf._listadoCuentas.Remove(item);
                        ParaisoFiscal.cantidadDeCuentas--;
                        retorno = true;
                        Console.WriteLine("Se retiró la cuenta"); //Dice informar de lo acontecido pero no sé si se hace acá adentro
                    }
                }
            }
            return pf;
        }

        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool retorno = false;

            if (pf is not null && pf is not null)
            {
                foreach (CuentaOffShore item in pf._listadoCuentas)
                {
                    if (pf != item)
                    {
                        pf._listadoCuentas.Add(item);
                        ParaisoFiscal.cantidadDeCuentas++;
                        retorno = true;
                        
                    }
                    else if(pf == item)
                    {
                        cos.Saldo += item.Saldo;
                    }
                }
            }
            return pf;
        }

       

        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Fecha de Inicio: {ParaisoFiscal.fechaInicioActividades}");
            sb.Append($"Lugar de Radicación:{_lugar}");
            sb.Append($"Cantidad de Cuentas:{ParaisoFiscal.cantidadDeCuentas}");
            foreach (CuentaOffShore item in _listadoCuentas)
            {
                Cliente.RetornarDatos(item.Dueño);
            }
            //return
        }


    }
}
