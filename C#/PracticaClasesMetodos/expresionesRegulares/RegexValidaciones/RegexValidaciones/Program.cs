//Programa que utiliza validaciones para una direccion de mail y una direccion web

using System.Text.RegularExpressions;
using static System.Net.WebRequestMethods;

namespace RegexValidaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail = "ivanamaitena@gmail.com";
            string direccionWeb = "https://www.youtube.com/watch?v=B_jD-5Dlkzo";

            string pattern1 = "(@)"; //Busca si hay un @
            string pattern2 = ".*?"; //Comprueba si hay una secuencia de caracteres (.), cero o mas veces (*) y toma los minimos posibles (?)
            string pattern3 = "\\.?"; //Comprueba si hay un punto 

            //Se trata de buscar la web indentica en la base de datos
            //Agrega "?" en los casos donde no es completamente necesario que vayan esos datos para que la pagina web
            //sea reconocida
            //Se usa "?" para hacer match de zero a mas veces
            //Usa \/\/ que seria como poner //
            //"^" indica que el enlace empieza con https: y el "$ indica que ahi termina"
            string pattern4 = @"^https:\/\/www\.youtube\.com\/watch\?v=B_jD\-5Dlkzo$";

            Regex regex1 = new Regex(pattern1+ pattern2 + pattern3, RegexOptions.IgnoreCase | RegexOptions.Singleline);

            Regex regex2 = new Regex(pattern4);

            //La clase Match presenta los resultados de una sola coincidencia en la comparacion, a diferencia de MatchCollection
            //la cual presenta varios conjuntos de matches

            Match match = regex1.Match(mail);

            if (match.Success) Console.WriteLine("Direccion de correo encontrada");
            else Console.WriteLine("Direccion de correo no encontrada");

            MatchCollection match2 = regex2.Matches(direccionWeb);

            if (match2.Count > 0) Console.WriteLine("Se ha encontrado la direccion web");
            else Console.WriteLine("No se ha encontrado la direccion web");


        }
    }
}
