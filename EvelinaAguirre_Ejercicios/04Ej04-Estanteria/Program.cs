using System;

namespace _04Ej04_Estanteria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creo un estante
            Estante estante = new Estante(3, 1);

            // Creo 4 productos
            Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);

            // Agrego los productos al estante
            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.Marca, (string)p1, p1.Precio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.Marca, (string)p1, p1.Precio);
            }

            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.Marca, (string)p1, p1.Precio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.Marca, (string)p1, p1.Precio);
            }

            if (estante + p2)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p2.Marca, (string)p2, p2.Precio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.Marca, (string)p2, p2.Precio);
            }

            if (estante + p3)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p3.Marca, (string)p3, p3.Precio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.Marca, (string)p3, p3.Precio);
            }

            if (estante + p4)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p4.Marca, (string)p4, p4.Precio);
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.Marca, (string)p4, p4.Precio);
            }

            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstante(estante));
        }
    }
}
