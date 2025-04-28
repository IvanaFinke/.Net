using System.Collections.Generic;
namespace LinkedListProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Empleados> Empleado = new LinkedList<Empleados>();
            Dictionary<string, LinkedList<Empleados>> empleadosPorDepartamento = new Dictionary<string, LinkedList<Empleados>>();


            int opcion, edad;
            string nombre;
            double sueldo;

            do
            {
                Console.WriteLine("Ingrese el nombre del empleado:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la edad del empleado:");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el sueldo del empleado:");
                sueldo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el departamento del empleado:");
                string departamento = Console.ReadLine();

                Empleados nuevoEmpleado = new Empleados(nombre, edad, sueldo, departamento);

                if (!empleadosPorDepartamento.ContainsKey(departamento))
                {
                    empleadosPorDepartamento[departamento] = new LinkedList<Empleados>();
                }

                empleadosPorDepartamento[departamento].AddLast(nuevoEmpleado);

                Console.WriteLine("Desea seguir ingresando empleados? (0 para salir / 1 para continuar)");
                opcion = Convert.ToInt32(Console.ReadLine());

            } while (opcion != 0);


            foreach (var departamento in empleadosPorDepartamento)
            {
                Console.WriteLine($"Departamento: {departamento.Key}");
                foreach (Empleados emp in departamento.Value)
                {
                    Console.WriteLine($"- {emp.GetNombre()}, {emp.GetEdad()} años, Salario: {emp.GetSueldo()}");
                }
            }

        }


    }

    class Empleados
    {
        private string nombre;
        private int edad;
        private double sueldo;
        private string departamento;

        public Empleados(string nombre, int edad, double sueldo, string departamento)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sueldo = sueldo;
        }

        public string GetNombre() { return nombre; }
        public int GetEdad() { return edad; }
        public double GetSueldo() { return sueldo; }
        public string GetDepartamento() { return departamento; }
    }
}

