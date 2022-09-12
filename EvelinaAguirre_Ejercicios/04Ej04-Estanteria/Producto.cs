using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Ej04_Estanteria
{
    public class Producto
    {
        private string codigoDeBarras;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarras, float precio)
        {
            this.marca = marca;
            this.codigoDeBarras = codigoDeBarras;
            this.precio = precio;
        }

        public string Marca
        {
            get
            {
                return this.marca;
            }
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarras;
        }

        public static string MostararProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca:{p.Marca}");
            sb.AppendLine($"Precio{p.Precio}");
            sb.AppendLine($"Código de barras:{p.codigoDeBarras}");
            return sb.ToString();
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return (!(object.ReferenceEquals(p1, null)) && !(object.ReferenceEquals(p1, null)) 
                && p1.codigoDeBarras == p2.codigoDeBarras && p1.Marca == p2.Marca);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1== p2);
        }
        public static bool operator ==(Producto p1, string pString)
        {
            return (p1.Marca == pString);
        }

        public static bool operator !=(Producto p1, string pString)
        {
            return !(p1 == pString);
        }



    }
}
