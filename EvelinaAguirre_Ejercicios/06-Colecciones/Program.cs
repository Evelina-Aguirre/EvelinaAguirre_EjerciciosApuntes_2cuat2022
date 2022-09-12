using System;
using System.Collections.Generic;

namespace _06_Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Los array se pueden pasar a colecciones
            //Mas usadas:
            //LISTA:
            //tipo de colección genérica
            //puede ser int, string, o de cualquier clase
            List<int> listaEnteros = new List<int>();
            List<string> listaString = new List<string>();

            listaEnteros.Add(5);

            foreach (int num in listaEnteros)//no modificar nada en la lista dentro de un foreach - antes o después ni durante
            {
                Console.WriteLine(num);
            }

            listaEnteros.Remove(5);//saca el valor una vez que lo encuentra, pero SOLO LA PRIMERA APARICIÓN. de haber otro 5 no lo quita 
            
            listaEnteros.RemoveAt(0);//elimina el indice 0

            //lAS LISTAS ESTÁN INDEXADAS, cada valor tiene una pocisión

            //////////////////////////////////////////////////////////////////////
            ////DICCIONARIO - clave , valor


            //
            Dictionary<string, string> diccionario = new Dictionary<string, string>();

            diccionario.Add("Saludo","Hola");
            diccionario.Add("Despedida", "Chau");
            diccionario.Add("Navidad", "Feliz Navidad");//izq key, derecha value

            /////////////////////////////////////////////////////////////////////
            //QUEUE

            //Cada vez que ingrese un elemento se agrega a lo último
            //cada vez que quito se remueve el primero
            Queue<int> queueNum = new Queue<int>();

            queueNum.Enqueue(1);//Agrega un valor al final 
            int num2 = queueNum.Dequeue(); //Remueve el primero


            //////////////////////////////////////////////////////////////////
            /////STACK
            ///
            Stack<int> stack = new Stack<int>();

            stack.Push(5);//empuja un elemento al final
            //stack.CopyTo(stack, 5);
            int ultimo = stack.Pop();//devuelve el último elemento ingrasado
            ////////////////////////////////////////////////////////////////////
            ///
            //SORTED LIST par clave valor como un diccionario pero se ordenan por clave

            SortedList<int, string> miSorted = new SortedList<int, string>();

            miSorted.Add(3,"Hola");
            miSorted.Add(4, "Hello");
            miSorted.Add(2, "chiao"); //Me lo ordena de menor a mayor o en orden alfabético 

           
            foreach (var item in miSorted)
            {
                Console.WriteLine(item.Value);
            }

        }
    }
}
