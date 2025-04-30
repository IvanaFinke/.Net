//El stack es parecido a las Queue's porque son colas LIFO (Last in first out); el ultimo num guardado
//es el primero en salir
//El stack se suele utilizar para procesos que requieran retroceder o almacenar posiciones anteriores. Ej; Deshacer acciones,
//juegos; como laberintos, sudokus, etc. Tambien historiales de paginas de internet, constrol de versiones en bases de datos.

namespace StackCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> num = new Stack<int>();

            int[] numeros = { 1, 2, 3, 4 };

            foreach (int i in numeros)
            {
                num.Push(i); //Va agregando al stack los valores del array uno encima del otro
            }

            num.Pop(); //Elimina el ultimo objeto agregado en el atack (el 4)

            Console.WriteLine("Conenido del stack:");
            foreach(int i in num)
            {
                Console.WriteLine(i); //imprime como quedo el array luego de pop 4, queda 3,2,1
            }

            Console.WriteLine("Con Peek podes ver el ultimo elemento del stack: {0}", num.Peek());

            int[] nuevoArray = new int[num.Count]; //Nuevo array con el tamaño del stack

            num.CopyTo(nuevoArray, 0); //pasar los valores de stack al array nuevoArray empezando con indice cero

            foreach(int i in nuevoArray)
            {
                Console.WriteLine(i);
            }

            int[] arrayTamDouble = new int[num.Count * 2]; //Creo array con el doble de elementos del stack
            num.CopyTo(arrayTamDouble, num.Count()); //A partir de la mitad del array en adelante, paso valores del stack

            Console.WriteLine("Imprimo el array que tiene el doble de tamaño del stack e imprime desde la mitad:");
            foreach(int i in arrayTamDouble)
            {
                Console.WriteLine(i);
            }
        }
    }
}
