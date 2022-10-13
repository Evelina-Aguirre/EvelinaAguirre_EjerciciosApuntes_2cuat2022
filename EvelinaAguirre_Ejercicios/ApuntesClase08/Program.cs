using System;

namespace ApuntesClase08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton
            //para crear una sola instancia de la clase
            //https://refactoring.guru/design-patterns/singleton
            //un singleton es una secuencia de un solo elemento o un conjunto unitario, es decir, con un solo miembro en el conjunto.
            //Y esa es la función básica de una clase de tipo singleton, que solo produce un único objeto: siempre el mismo objeto.



            //HERENCIA
            //RELACIÓN ENTRE CLASES, SE COMPARTEN ATRIBUTOS Y MÉTODOS HEREDADOES EN OTRA CLASE
            //Clase base o pare y clase derivada o clase hija
            //La clase base por lo general es genérica - 
            //Las clases definen comportamientos y carácterísticas a través de sus métodos
            //va a poseer los atributos y los métodos de la clase padre además de los métodos propio
            
            /////////////////////////////////////////////////////////////////////////////////////////////////
            //TIPOS DE HERENCIA:
            //HERENCIA SIMPLE : SOLO PUEDE HEREDAR DE UN PADRE
            //MULTIPLE: NO LA TIENE C#
            //TRANSITIVA(Herencia multinivel): De una clase hereda una de esa hereda otra, todas propiedades que
            //tenga A la va a tener B y todo lo que tenga b lo va a tener C
            //C contendría cosas de a o de b, además las suyas propias.
            //
            //Principio sustituciópn liskov:
            //Si T es derivado de S, los objetos de tipo S pueden ser tratados como tipos T.
            //Si tengo la clase animal, derivado de perro, todo lo que puede hacer el animal lo puede hacer el perro
            //pero no todo lo que hace el perro lo puede hacer el animal
            //
            Perro p1 = new Perro("Juan", 3, "Masc");
            Gato g1 = new Gato("gatito",1,"Fem");
            p1.Saludar();
            g1.Saludar();



        }
    }
}
