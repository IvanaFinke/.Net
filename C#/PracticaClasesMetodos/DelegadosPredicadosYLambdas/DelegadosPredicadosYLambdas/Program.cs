namespace DelegadosPredicadosYLambdas
{
    class Program
    {
        //Crea instancia de delegado. Cuando llames el delegado en main debe de tener mismos parametros y tipo
        delegate int Operacion(int x, int y);

        //Crea instancia de delegado.
        delegate string Texto(string msj);

        static void Procesar(Operacion operacion, int x, int y) //Funcion que recibe un delegado con parametros e imprime
        {
            Console.WriteLine(operacion(x, y)); //lleva como parametro el delegado con sus variables como parametro
        }

        static void Impresion(Texto texto, string mensaje)
        {
            Console.WriteLine(texto(mensaje));
        }
        static void Main(string[] args)
        {
            //Crea un objeto de clase calculadora
            Calculadora c = new Calculadora();

            Console.WriteLine("Ingrese un 0 para sumar o un 1 para restar");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion)
            {
                case 0:
                    Console.WriteLine("Ha elegido la operacion suma");
                    Console.WriteLine("Ingrese el primer numero a sumar:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero a sumar:");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    //Crea objeto de clase delegate y le mete el objeto de la clase Calculadora con la funcion Sumar 
                    Operacion Suma = c.Sumar;

                    //Llama a la funcion estatica procesar; donde van el delegado y los parametros de la funcion
                    Console.WriteLine("El resultado es:");
                    Procesar(Suma, num1, num2);
                    break;

                case 1:
                    Console.WriteLine("Ha elegido la operacion resta");
                    Console.WriteLine("Ingrese el primer numero a restar:");
                    int numrest1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero a restar:");
                    int numrest2 = Convert.ToInt32(Console.ReadLine());

                    //Crea objeto de clase delegate y le mete el objeto de la clase Calculadora con la funcion Restar 
                    Operacion Resta = c.Restar;

                    //Llama a la funcion estatica procesar; donde van el delegado y los parametros de la funcion
                    Console.WriteLine("El resultado es:");
                    Procesar(Resta, numrest1, numrest2);
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

            //Usando delegados con clases con metodos staticos:
            //No se instanci una clase, se llama directamente a la clase con la funcion

            //Inicializa un delegado de tipo string que almacena a la clase saludo con su metodo
            Texto mensaje = Saludo.ImpresionSaludo;
            Impresion(mensaje, "Hola como estas estoy probando los delegados con las clases static");


        }
    }

    class Calculadora
    {
        public int Sumar(int x, int y) => x + y;
        public int Restar(int x, int y) => x - y;
    }

    class Saludo
    {
        public static string ImpresionSaludo(string mensaje) => mensaje;
    }
}