using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Ej2_Cotizador
{
    public class Peso
    {
        private double cantidad;
        private static double cotxRespetoDolar;

        static Peso()
        {
            Peso.cotxRespetoDolar = 140.94;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotxRespetoDolar = cotizacion;
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
                return Peso.cotxRespetoDolar;
            }
        }

        //Sobrecarga implícita de double
        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }
        //Sobrecargas explícitas para dolar y Euro
        public static explicit operator Dolar(Peso p)
        {
            //return (Dolar)p; 
            return new Dolar((p.GetCantidad / Peso.GetCotxRestoDolar));
        }
        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
            //Peso lo paso a Dolar y eso a Euro para reutilizar las conversiones explícitas de las clases Dolar y Euro.
        }


        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad == p2.GetCantidad;
        }

        public static bool operator==(Peso p, Dolar d)
        {
            return p.GetCantidad == d.GetCantidad;
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return p.GetCantidad == e.GetCantidad;
        }


        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
        public static bool operator !=(Peso p1, Dolar d)
        {
            return !(p1 == d);
        }
        public static bool operator !=(Peso p1, Euro e)
        {
            return !(p1 == e);
        }

        public static Peso operator +(Peso p, Dolar d )
        {
            return p.GetCantidad + ((Peso)d).GetCantidad; 
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return p.GetCantidad + ((Peso)e).GetCantidad;
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return p.GetCantidad - ((Peso)d).GetCantidad;
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return p.GetCantidad -((Peso)e).GetCantidad;
        }






    }
}
