using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Ej04_Estanteria
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] Productos
        {
            get
            {
                return this.productos;
            }
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Ubicación Estante {e.ubicacionEstante}");
            foreach (Producto item in e.Productos)
            {
                sb.AppendLine($"Producto: {item}");

            }
            sb.AppendLine($"**********************");
            return sb.ToString();
        }

        public static bool operator ==(Producto p, Estante e)
        {
            bool retorno = false;
            foreach (Producto item in e.Productos)
            {
                if (p == item)
                    retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto p, Estante e)
        {
            return !(p==e);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool retorno=false;

            for (int i = 0; i < e.Productos.Length; i++)
            {
                if(object.ReferenceEquals(e.productos[i], null) && p != e)
                {
                    e.Productos[i] = p;
                    retorno = true;
                }

            }
            return retorno;
        }

        public static bool operator -(Estante e, Producto p)
        {
            bool retorno = true;

            if (p==e)
            {
                for (int i = 0; i < e.Productos.Length; i++)
                {
                    if(e.Productos[i]==p)
                    {
                        e.Productos[i] = null;
                        retorno = true;
                    }
                }
               
            }
            return retorno;
        }





    }
}
