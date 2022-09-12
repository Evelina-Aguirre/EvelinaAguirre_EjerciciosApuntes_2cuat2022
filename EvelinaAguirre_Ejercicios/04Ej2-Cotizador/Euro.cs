using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Ej2_Cotizador
{
    public class Euro
    {

        private double cantidad;
        private static double cotxRespetoDolar;

        static Euro()
        {
            Euro.cotxRespetoDolar = 1.01;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion):this(cantidad)
        {
            Euro.cotxRespetoDolar = cotizacion;
        }

        public double GetCantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        public static double GetCotxRestoDolar
        {
            get
            {
                return Euro.cotxRespetoDolar;
            }
        }

        //Sobrecarga implícita de double
        public static implicit operator Euro(double d )
        {
            return new Euro(d);
        }

        //sobrecargas explícitas para peso y dolar 
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar((e.cantidad / Euro.GetCotxRestoDolar));
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
            //para pasar de euros a pesos, explicitamente decimos que "e" se convierta en dolar y eso a su vez en Peso.
            //Ambas conversiones explícitas ya hechas en la clase Dolar.
        }


        public static bool operator ==(Euro e1, Euro E2)
        {
            return e1.GetCantidad == E2.GetCantidad;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e.GetCantidad ==d.GetCantidad;
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return e.GetCantidad == p.GetCantidad;
        }


        public static bool operator !=(Euro e1, Euro E2)
        {
            return !(e1 == E2);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }


        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad + ((Euro)p).GetCantidad);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad + ((Euro)d).GetCantidad);
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad - ((Euro)p).GetCantidad);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad- ((Euro)d).GetCantidad);
        }

    }
}
