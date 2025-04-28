using System.Collections.Generic;
namespace ListC
{   
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            foreach(int i in new int[] {0,2,4,6,8,10}) //AGREGA UN ARRAY DENTRO DE LA LISTA
            {
                list.Add(i);
            }

            foreach(int j in list)
            {
                Console.WriteLine(j);
            }

            List<int> lista2 = new List<int>();

            Console.WriteLine("Cuantos elementos desea agregar en la lista?");
            int elemen = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < elemen; i++)
            {
                Console.WriteLine("Ingrese un numero entero:");
                int num = Convert.ToInt32(Console.ReadLine());
                lista2.Add(num);

            }

            foreach(int i in lista2)
            {
              
                Console.WriteLine(i);
            }

            List<string> nombres = new List<string>();
            int opcion;

            do
            {
                Console.WriteLine("Ingrese nombre:");
                string nombre = Console.ReadLine();
                nombres.Add(nombre);

                Console.WriteLine("Desea seguir agregando nombres? (1 CONTINUA - 0 SALIR)");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion != 0);

            nombres.RemoveAt(nombres.Count - 1); //elimina ultima posicion
            foreach (string i in nombres)
            {
                
                Console.WriteLine(i);
            }

            List<int> listaNum = new List<int>();

            int element;

            do
            {
                Console.WriteLine("Ingrese un numero entero:");
                element = Convert.ToInt32(Console.ReadLine());
                listaNum.Add(element);
            } while (element != 0);

            listaNum.RemoveAt(listaNum.Count - 1);

            foreach(int i in listaNum)
            {
                Console.WriteLine(i);
            }




        }
    }
}