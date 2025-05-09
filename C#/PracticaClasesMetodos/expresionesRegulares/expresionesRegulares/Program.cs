using System.Text.RegularExpressions;

namespace expresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo texto a evaluar
            string texto = "Hola, como estas? Romeo te amo. Gracias por todo 100 2000 122";

            //Ahora creo la condicion que busca una G mayuscula en el texto
            string pattern = "[G]";

            //Ahora inicializo la clase Regex, que va a contener a la condicion
            Regex regex1 = new Regex(pattern);

            //Inicializo una coleccion que va a contener todas las G mayuscula que encuentre
            MatchCollection aciertos = regex1.Matches(texto);

            //Imprime la cantidad de aciertos:
            if (aciertos.Count > 0) Console.WriteLine("Se encontro la G {0} veces", aciertos.Count);
            else Console.WriteLine("No encontrado");

            //Se busca un conjunto de 3 decimales que esten juntos y que antes tengan un espacio delante
            string pattern2 = @" \d{3}";

            //Inicializa la condicion dentro de la clase regex
            Regex regex2 = new Regex(pattern2);

            //Almacena todos los aciertos en la coleccion
            MatchCollection coleccionDeAciertos = regex2.Matches(texto);

            //Imprime la coleccion de aciertos
            if (coleccionDeAciertos.Count > 0) Console.WriteLine("Se han encontrado {0} conjuntos de un bloque de 3 numeros", coleccionDeAciertos.Count);
            else Console.WriteLine("No se han encontrado");

            string texto2 = "Hola hola Romeo, la vida, la vida es un carnaval";

            //Patron que busca una uno o mas caracteres de una palabra, seguido espacio en blanco, repite y vuelve a buscar tamaño
            // '?' = caracter opcional, '+' = una o mas apariciones, '\w' = caracteres alfanumericos, '*' = cero o mas apariciones
     

            string pattern3 = @"\b(\w+?)\s\1\b";

            Regex regex3 = new Regex(pattern3);

            MatchCollection coleccion3 = regex3.Matches(texto2);

            Console.WriteLine("El texto con repeticiones se encontro y elimino con Regex.Options.IgnoreCase");
            foreach(Match match in Regex.Matches(texto2, pattern3, RegexOptions.IgnoreCase))
            {
                //Imprime el valor encontrado, oracion exacta que esta repetida y la posicion en el texto donde repite
                Console.WriteLine("Se duplica {0}, duplica: {1} en la posicion: {2}",match.Value, match.Groups[1].Value, match.Index);
            }
            //Expresion regular, se puede agregar en corchetes si se quiere tomar en cuenta distintos caracteres para
            //una misma palabra
            string pattern4 = "(Gat[oa]\\.? |gat[oa]\\.?)";

            string[] texto3 = { "El Gato gato Lucas y la gata Gata Dimi estan jugando" };

            foreach(string textito in texto3)
            {
                //Quita de la cadena las palabras del pattern con string.empty
                Console.WriteLine(Regex.Replace(textito, pattern4, String.Empty));
            }

            string texto4 = "Vamos a probar otro texto: ABCDE 1234, Lulu, Lucas, Dimi. . :,.";

            //Estoy buscando la coincidencia de valores de A a la Z que esten en un conjunto de 5 elementos
            string pattern5 = "[A-Z]{5}";

            Regex regexRango = new Regex(pattern5);

            MatchCollection nuevaColeccion = regexRango.Matches(texto4);

            foreach(Match match in nuevaColeccion)
            {
                //Imprimo el contenido del texto que coincide con el patron "ABCDE"
                Console.WriteLine("Valores del rango encontrados {0}", match.Value);
            }

            string pattern6 = @"\.|\,|\:";

            Regex signosPuntuacion = new Regex(pattern6);

            MatchCollection coleccionSignos = signosPuntuacion.Matches(texto4);

            Console.WriteLine("Cantidad de signos de puntuacion encontrados: {0}", coleccionSignos.Count);
           





        }
    }
}