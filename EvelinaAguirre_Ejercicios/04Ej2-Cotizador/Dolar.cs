using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Ej2_Cotizador
{
    public class Dolar
    {
        private double cantidad;
        private static double cotxRespetoDolar;

        static Dolar()
        {
            Dolar.cotxRespetoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotxRespetoDolar):this(cantidad) 
        {
            Dolar.cotxRespetoDolar = cotxRespetoDolar;
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
                return Dolar.cotxRespetoDolar;
            }
        }

    
        //sobrecarga de double de forma implícita
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        //sobrecargas explícita de Euro y Peso
        public static explicit operator Euro(Dolar d)
        {
            return new Euro((d.cantidad * Euro.GetCotxRestoDolar));
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso((d.cantidad*Peso.GetCotxRestoDolar));
        }
        
        
        
        //Comparadores de operadores aritméticos

        public static bool operator == (Dolar d1, Dolar d2)
        {
            return d1.GetCantidad == d2.GetCantidad;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1== d2); //Para reutilizar la comparación del método anterior
        }


        public static bool operator ==(Dolar d, Euro e)
        {
            return d.GetCantidad == (Dolar)e.GetCantidad;  //En la consigna aclara que los operadores de comparación == compararán cantidades.
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }


        public static bool operator ==(Dolar d, Peso p)
        {
            return d.GetCantidad == (Dolar)p.GetCantidad; 
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }


        public static Dolar operator - (Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad -((Dolar)p).GetCantidad);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad - ((Dolar)e).GetCantidad);
        }


        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad + ((Dolar)p).GetCantidad);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad + ((Dolar)e).GetCantidad);
        }

    }
}