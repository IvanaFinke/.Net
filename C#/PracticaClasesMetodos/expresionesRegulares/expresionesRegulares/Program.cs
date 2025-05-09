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
            string pattern3 = @"\b(\w+?)\s\1\b";

            Regex regex3 = new Regex(pattern3);

            MatchCollection coleccion3 = regex3.Matches(texto2);

            Console.WriteLine("El texto con repeticiones se encontro y elimino con Regex.Options.IgnoreCase");
            foreach(Match match in Regex.Matches(texto2, pattern3, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("Se duplica {0}, duplica: {1} en la posicion: {2}",match.Value, match.Groups[1].Value, match.Index);
            }

            string pattern4 = "(Gato\\.? |Gata\\.? |gato\\.? |gata\\.?)";

            string[] texto3 = { "El Gato Lucas y la gata Dimi estan jugando" };

            foreach(string textito in texto3)
            {
                //Quita de la cadena las palabras del pattern con string.empty
                Console.WriteLine(Regex.Replace(textito, pattern4, String.Empty));
            }


          

        }
    }
}