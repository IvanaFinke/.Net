using System.Runtime.CompilerServices;

//Los Delegados predicados devuelven true o false
//Utilizados para buscar valores dentro de las listas

namespace DelegadosPredicados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            numeros.AddRange(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,10 });

            Predicate<int> predicado1 = new Predicate<int>(buscoPares);

            List<int> pares = numeros.FindAll(predicado1);

            foreach(int i in pares)
            {
                Console.WriteLine(i);
            }

            //Usando clases:
            Empleados emp1 = new Empleados("Maite",1000,22);
            Empleados emp2 = new Empleados("Romeo", 2000,28);
            Empleados emp3 = new Empleados("Ace", 3000,26);

            List<Empleados> listaEmpleados = new List<Empleados>();


            listaEmpleados.AddRange(new Empleados[] { emp1, emp2, emp3});

            //Predicado para saber que usuarios cobran el sueldo minimo, coloca como argumento
            //la funcion estatica booleana sueldoMinimo 
            Predicate<Empleados> veridicoSueldo = new Predicate<Empleados>(sueldoMinimo);

            List<Empleados> buscoSueldoMin = listaEmpleados.FindAll(veridicoSueldo);
            Console.WriteLine("Epleados con sueldo minimo:");
            foreach(Empleados i in buscoSueldoMin)
            {
                Console.WriteLine("Nombre {0} - Sueldo: {1}", i.Nombre, i.Sueldo);
            }

            //Predicado para saber si los empleados son mayores a 20 años, inicializa predicado y se coloca
            //la funcion booleana como argumento del predicado
            Predicate <Empleados> edadMayor20= new Predicate<Empleados>(mayorA20);
           
            List<Empleados> listaEdades = listaEmpleados.FindAll(edadMayor20);

            Console.WriteLine("Empleados mayores a 20:");
            foreach (Empleados i in listaEdades)
            {
                Console.WriteLine("Nombre: {0} - Edad: {1}",i.Nombre, i.Edad);
            }

            bool hayMayores20 = listaEmpleados.Exists(edadMayor20);

            if(hayMayores20)
            {
                Console.WriteLine("Si, hay {0} empleados mayores de 20",listaEdades.Count());
            }
            else
            {
                Console.WriteLine("Los empleados tienen menos de 20 años");
            }
            
        }

        static bool buscoPares(int numeros)
        {
            if (numeros % 2 == 0) return true;
            else return false;
        }

        static bool sueldoMinimo(Empleados emp)
        {
            if (emp.Sueldo <= 1000) return true;
            else return false;
        }

        static bool mayorA20(Empleados emp)
        {
            if (emp.Edad > 20) return true;
            else return false;
        }
    }

    class Empleados
    {
        private string nombre;
        private double sueldo;
        private int edad;

        public Empleados(string nombre, double sueldo, int edad)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
            this.edad = edad;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public int Edad { get => edad; set => edad = value; }
    }

}