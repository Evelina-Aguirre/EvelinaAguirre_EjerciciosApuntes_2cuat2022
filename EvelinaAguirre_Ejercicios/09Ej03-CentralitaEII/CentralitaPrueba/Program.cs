using System;
using _08Ej04_CentralitaEntidades;

namespace CentralitaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            // central
            Centralita c = new Centralita("Center");

            // 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", EFranja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(EFranja.Franja_3, l2);

            
           /* Reescribir el método Main para que:
            Sólo agregue mediante el operador +.
            Sólo muestre los datos de Centralita una vez ordenados.*/
            c += l1;
            Console.WriteLine(c.ToString());
            c += l2;
            Console.WriteLine(c.ToString());
            c += l3;
            Console.WriteLine(c.ToString());
            c += l4;
            Console.WriteLine(c.ToString());

            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());

        }
    }
}
