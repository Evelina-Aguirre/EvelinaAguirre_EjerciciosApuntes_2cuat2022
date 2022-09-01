using System;

namespace clase03Apuntes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un objeto es una instancia de una clase.
            //El nombre de la clase va a ser una nueva clase de dato-

            //nombreDeClase.Metodo
            //Las clases son de tipo de referencia, está en la memoria heap. 
            //con new reserva un espacio en memoria para ese objeto.
            //cada clase para instanciar tiene un construcvtor que le da valor a los atributos
            //siempre hay un constructor vacio, si es un entero le pone cero, booleano false, y así.
            //le doy valor a los atributos de la clase 
            // si hago un atributo estático llamado nombre todos van a tener el mismo nombre
            string nombre;
            _03Animal animal1 = new _03Animal("gatito",2,"gato");
            _03Animal animal2 = new _03Animal("perrito",5);

            //animal1.nombre = "gatito";
            //animal1.tipo = "gato";
            //animal1.edad = 5;
            //animal2.nombre = "marta";
            //animal2.tipo = "indefinido";
            //animal2.edad = 2;

            Console.WriteLine(animal1.Hablar());
            Console.WriteLine(animal2.Hablar());

            // animal1.Hablar();

            //para ver como va el atributo estático
            Console.WriteLine( _03Animal.contadorDeAnimales); //tendría que tener dos animales ya que se inicializa en el ctor estático
                                                              //y se incrementa en el constructor normal ++;



            _03Animal animal3 = new _03Animal("gatito", 2, "gato");
            _03Animal animal4 = new _03Animal("gatito", 2, "gato");
            //para comparar dos objetos iguales
            if (animal3 == animal4)  //POR CADA NEW SE RESERVA UN ESPACIO DE MEMORIA DIFERENTE
            {
                Console.WriteLine("son iguales");
            }
            else
            {
                Console.WriteLine("sON DIFERENTES");
            }
            //DADO QUE SON DIFERENTES, NO COMPARA VALOR DEL NOMBRE CON VALOR DEL NOMBRE x ej, COMPARA POSICIONES DE MEMORIA.
            //SI LO HACE SI COMPARAMOS LOS ELEMENTOS DE CADA UN animal3.nombre == animal4.nombre


            //si escribimos animal3 = animal4;   animal 3 va a apuntar a la misma dire de memoria que animal 4.
        }
    }
}
