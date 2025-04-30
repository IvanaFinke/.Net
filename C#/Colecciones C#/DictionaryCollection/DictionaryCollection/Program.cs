namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> diccionario = new Dictionary<string, int>();

            diccionario["Romeo"] = 28; //Forma 1 de almacenar valores dentro de diccionario; [] para clave = para valor
            diccionario["Ace"] = 29;
            diccionario["Maite"] = 22;
            diccionario.Add("Edmond", 30); //Forma 2; izquierda la clase, derecha valor

            foreach (KeyValuePair<string, int> muestro in diccionario) //KeyValuePair recupera la clave y el valor dentro de diccionario
            {
                Console.WriteLine("La clave: {0} - valor: {1}", muestro.Key, muestro.Value); //Muestra clave y valor de diccionario
            }
        }
    }
}