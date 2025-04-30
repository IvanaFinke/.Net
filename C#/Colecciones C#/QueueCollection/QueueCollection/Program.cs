//Queue es un tipo de collecion de orden FIFO, usado en sistemas secuenciales
//Ejecuta operaciones en orden y las va despachando desde la primera a la ultima
//Usada para procesar tareas pendientes, cola de impresion de una impresora, sistema de mensajeria y manejo de eventos

//El programa consiste en un sistema de atencion a una cola de clientes
using System.Collections.Generic;
namespace QueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clientes = new Queue<string>();

            int opcion;

            do
            {
                Console.WriteLine("¡Bienvenid@! Ha entrado al menú de control de servicio de atención.");
                Console.WriteLine("Ingrese la opción que desee:");
                Console.WriteLine("1. Ingresar cliente");
                Console.WriteLine("2. Atender cliente");
                Console.WriteLine("3. Mostrar clientes en espera");
                Console.WriteLine("4. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del cliente");
                        string nombre = Console.ReadLine();
                        clientes.Enqueue(nombre);
                        break;

                    case 2:
                        string cliente = clientes.Dequeue();
                        Console.WriteLine($"Atender a cliente: {cliente}");
                        
                        break;

                    case 3:
                        Console.WriteLine("Los clientes en espera son:" + clientes.Count());

                        foreach(string i in clientes)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                        
                }


            } while (opcion != 4);
        }
    }
} 