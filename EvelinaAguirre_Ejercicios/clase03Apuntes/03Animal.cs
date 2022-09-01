using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase03Apuntes
{
    public class _03Animal
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        //ESTO ES ABSTRAER - la abstracción es para crear el molde

        //ATRIBUTOS - qué caracteristicas tiene un animal en este caso mascota, que datos me interesan
        //nombre
        //edad
        //tipo

        //METODOS - qué acciones realiza acciones
        //Hablar
        //Comer

        /////////////////////////////////////////////////////////////////////////////////////////////////////

        //ATRIBUTOS
        public string nombre;
        public int edad;
        public string tipo;
        //UN ATRIBUTO ESTÁTICO ES ALGO QUE VAN A COMPARTIR TODOS LOS OBJETOS, POR EJ SI TENES CANTIDAD DE NAFTA LO HACES ESTÁTICO
        //EL PROX QUE USE NAFTA SI EL ANTERIOR USO VA A TENER MENOS NAFTA
        //EJ ATRIBUTO ESTÁTICO
        public static int contadorDeAnimales; // en el constructor lo inicias
        
        static _03Animal()//los constructores estáticos no se llaman, todas las instancias todos los objetos vana compartir el mismo dato
        {
            _03Animal.contadorDeAnimales=0; // cada ve que llamo un animal se va a sumar uno a este contador por sr estático 
            //TODOS LOS ATRIBUTOS ESTÁTICOS SE TIENEN QUE INICIALIZAR CON UNS CONSTRUCTOR ESTÁTICO
        }
        //los atributos estáticos se ejecutan una sola vez y nunca más

        //METODOS
        public string Hablar()
        {
            //return "Miuau";
            //CON STRINGBUILDER
            StringBuilder sb = new StringBuilder();
            sb.Append("Mi nombre es");//escribe una cosa al lado de la otra
            sb.AppendLine(this.nombre);//escribe y hace un salto de linea
            sb.Append($"Mi nombre es {this.nombre}, yo soy un {this.tipo}");
            sb.Append(this.edad.ToString());
            //return sb;// si el metodo tiene que devolver string va a dar error porque el sb ees un objeto. x eso se hace 
            return sb.ToString();//PARA PASARLO A STRING
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////

        //CONTRUCTOR
        //La clase tiene un constructor publico por default sin ningun parámetro:

        //public _03Animal()
        //{
        //    nombre = "sin nombre";
        //    edad = 0;
        //    tipo = "gatito";
        //}


        //tiene dos referencias porque cree dos objetos de este en el program
        //si se setea dentro de este por default todos los objetos que se creen aa partir de este va a tener esos valores fijos
        //se pueden recargar los constructores
        //pueden ser constructores estáticos o no estáticos
        //si creamos un constructor se anula el contructor por defecto

        //public _03Animal(string nombre, int edad, string tipo) 
        //{
        //    this.nombre = nombre;
        //    this.edad = edad;
        //    this.tipo = tipo;
        //}
        //nombre de la clase si tengo que llamar a algún atributo estático}




        public _03Animal(string nombre, int edad, string tipo = "perro")//si no especifico que clse de animal es el valor por defecto va a ser perro
        {
            _03Animal.contadorDeAnimales++;
            this.nombre = nombre;
            this.edad = edad;
            this.tipo = tipo;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////







    }
}
