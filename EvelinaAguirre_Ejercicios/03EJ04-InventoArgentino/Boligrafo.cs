using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03EJ04_InventoArgentino
{
    public class Boligrafo
    {
        /*Ejercicio I04 - Invento argentino
            Consigna
            En un proyecto de biblioteca de clases, crear la clase Boligrafo a partir del siguiente diagrama:

            Diagrama de clases

            La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante cantidadTintaMaxima 
            en Boligrafo donde se guardará dicho valor.x
            Generar los métodos getter GetColor y GetTinta para los correspondientes atributos (sólo retornarán el valor de los mismos).x
            Generar un método setter privado SetTinta que valide el nivel de tinta y, si es válido, modifique el valor del atributo tinta.
            El argumento tinta contedrá la cantidad de tinta a agregar o quitar. Podrá ser positivo (cargar tinta) o negativo (gastar tinta).
            Se deberá validar que el nivel de tinta resultante sea mayor o igual a cero y menor o igual a cantidadTintaMaxima. Si no es válido, no se deberá modificar el atributo ni realizar ninguna acción.
            El método Recargar colocará la tinta en su nivel máximo. Reutilizar código.
            El método Pintar restará la tinta gastada (reutilizar código). El parámetro gasto representará la cantidad de unidades de tinta a utilizar y utilizará tanta tinta como tenga disponible sin quedar en negativo. Utilizando el parámetro dibujo informará el resultado retornando tantos * como unidades de tinta haya gastado, por ejemplo:
            Si no había nada de tinta retornará una cadena de texto vacía.
            Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.
            Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.
            Agregar un proyecto de consola.
            En el método Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
            Utilizar todos los métodos y mostrar los resultados por consola.
            Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.*/
        
        const short cantidadDeTintaMixta = 100;//hey.. constante 
        private ConsoleColor color;
        private short tinta;



        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor
        {
            get
            {
                return this.color;
            }
        }

        public short GetTinta
        {
            get
            {
                return this.tinta;
            }
        }
        private short SetTinta
        {
            set//me va a pasar cuanta tinta cargar o gastar, puede ser positivo o negativo
            {
                if((this.tinta += value) >= 0 && value <= Boligrafo.cantidadDeTintaMixta )
                {
                    this.tinta += value;
                }
                
            }
        }

        public void Recargar()
        {
            this.SetTinta =cantidadDeTintaMixta;
        }

        //public bool Pintar(short gasto, out string dibujo)
        //{

        //    bool retorno = false;
        //    StringBuilder sb = new StringBuilder();

            
        //            for (int i = 0; i < gasto; i++)
        //            {
        //                sb.Append("*");
        //            }
        //            Console.ForegroundColor = GetColor;
        //            this.SetTinta = gasto;
        //            retorno = true;
                  
           
        //    dibujo = sb.ToString();
        //    return retorno;

        //}



    }
}
