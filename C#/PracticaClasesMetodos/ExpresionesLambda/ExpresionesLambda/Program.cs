using System.Collections.Generic;
namespace EmpresionesLambda
{
    class program
    {
        static void Main(string[] args)
        {
            //Quiero crear una expresion labda que sea utilizada en un delegate que imprima los num que son
            //pares

            List<int> list = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //Objeto predicate utilizando expresiones lambda
            Predicate<int> esPar = new Predicate<int>(num => num % 2 == 0);

            //Guarda en el array todos los numeros pares que encuentre:
            List<int> listaPares = list.FindAll(esPar);

            //Foreach realizado en forma de expresion lambda:
            listaPares.ForEach(num => { Console.WriteLine("Numero par:"); Console.WriteLine(num); });

            //Otro que tome numeros y devuelva el num multiplidado por el doble

            //Nuevo objeto funcion que utiliza expresion lambda
            Func<int, int> ope1 = num => num * num;

            //Nueva lista con todos los numeros, multiplicandolos por si mismos.
            List<int> guardoValoresPotenciados = list.Select(ope1).ToList();

            guardoValoresPotenciados.ForEach(num => { Console.WriteLine("Valor potenciado"); Console.WriteLine(num); });

            Operacion ope2 = (num => num * num);
            Console.WriteLine("El numero cuadrado de 5 es {0}", ope2(5));

            //Otro que tome una clase y clasifique si tienen misma edad
            personas persona1 = new personas("Maite", 22);
            personas persona2 = new personas("Romeo", 22);
            personas persona3 = new personas("Edmond", 23);
            personas persona4 = new personas("Ace", 24);


            comprueboEdadIgual edadIgual = (per1, per2) => (per1 == per2);

            Console.WriteLine("Maite tiene la misma edad que romeo?");
            Console.WriteLine(edadIgual(persona1.Edad, persona2.Edad));
        }

        public delegate int Operacion(int num);
        public delegate bool comprueboEdadIgual(int edad, int edad2);
    }

    class personas
    {
        private string nombre;
        private int edad;
        public personas(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}