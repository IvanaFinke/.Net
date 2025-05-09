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
            string direccionWeb = "https://www.google.com";

            //Patron que busca exactamente "@" y"." seguido del @ para verificar que la direccion es valida
            string pattern1 = @"@.*\.";

            //Se trata de buscar la web indentica en la base de datos
            //Agrega "?" en los casos donde no es completamente necesario que vayan esos datos para que la pagina web
            //sea reconocida
            //Se usa "?" para hacer match de zero a mas veces
            string pattern2 = "https?://(www.)?google.com";

            Regex regex1 = new Regex(pattern1, RegexOptions.IgnoreCase | RegexOptions.Singleline);

            Regex regex2 = new Regex(pattern2);

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
