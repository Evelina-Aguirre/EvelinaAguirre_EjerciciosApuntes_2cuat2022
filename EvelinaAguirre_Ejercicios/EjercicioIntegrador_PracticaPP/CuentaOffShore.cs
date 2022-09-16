using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador_PracticaPP
{
    public class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroDeCuenta;
        private double _saldo;

        public CuentaOffShore(Cliente dueño, int numero, double saldoInicial)
        {
            this._dueño = dueño;
            this._numeroDeCuenta = numero;
            this._saldo = saldoInicial;
        }

        public CuentaOffShore(string nombre, ETipoCliente tipo, int numero, double saldoInicial):this(new Cliente(tipo,nombre),numero,saldoInicial)
        {
            
        }
        public Cliente Dueño
        {
            get
            {
                return this._dueño;
            }
        }

        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                this._saldo = value;

            }
        }

        public static implicit operator int (CuentaOffShore cos)
        {
            return cos._numeroDeCuenta;
        }

        public static bool operator ==(CuentaOffShore c1, CuentaOffShore c2)
        {
            bool retorno = false;
            if(c1 is not null && c2 is not null && c1._numeroDeCuenta == c2._numeroDeCuenta
                && c1._dueño.GetAlias() == c2._dueño.GetAlias())
            {
                retorno = true;
            }
            return retorno;
            
        }
        public static bool operator !=(CuentaOffShore c1, CuentaOffShore c2)
        {
            return !(c1 == c2);
        }
    }
}
