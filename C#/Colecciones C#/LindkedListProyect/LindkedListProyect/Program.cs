
using System.Collections.Generic;
using System.Text.Json.Nodes;
namespace LinkedListproyect
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numero = new LinkedList<int>(); //CREA LINKEDLIST DE VALORES ENTEROS

            int[] numeros = new int[] { 1, 2, 3, 4 };

            foreach (int i in numeros) //AGREGA A LO ULTIMO DE CADA POSICION EN LA LINKED LIST CADA NUM DEL ARRAY
            {
                numero.AddLast(i);
            }

            foreach (int i in numero)
            {
                Console.WriteLine(i); //IMPRIME LO AGREGADO ANTERIORMENTE 
            }

            LinkedList<string> palabra = new LinkedList<string>(); //NUEVA LINKEDLIST DE STRINGS

            string[] palabras = new string[] { "Romeo", "Edmond", "Ace", "Oberon" };

            for (int i = 0; i < palabras.Length; i++) //AGREGO EL ARRAY A LA LINKEDLIST SEGUN TAM DEL ARRAY (LENGTH)
            {
                palabra.AddFirst(palabras[i]);
            }

             Console.WriteLine("LinkedList con un nodo agregado:");
            foreach (string i in palabra)
            {
              Console.WriteLine(i);
            }

            for (LinkedListNode<int> nodoNum = numero.First; nodoNum != null; nodoNum = nodoNum.Next)
            {
                int num = nodoNum.Value; //almacena los valores dentro del nodo
                Console.WriteLine(num);
            }

            LinkedListNode<string> otroNodoNombre = new LinkedListNode<string>("Lilia"); //agrego nodo de otro elemento string a la LinkedList de string
            palabra.AddLast(otroNodoNombre);

            Console.WriteLine("LinkedList con un nodo agregado:");
            foreach (string i in palabra)
            {
                Console.WriteLine(i);
            }

            numero.Remove(2); //Saco valor de la linkedlist de numeros

            Console.WriteLine("Linked list con elemento 2 eliinado:");
            foreach (int i in numero)
            {
                Console.WriteLine(i);

            }


        }
    }
}