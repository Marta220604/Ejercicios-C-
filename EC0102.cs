class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce una palabra:");
        string palabra = Console.ReadLine();

        Invertir(palabra, palabra.Length - 1);
    }

    static void Invertir(string cadena, int posicion)
    {
        //si llegamos al principio de la cadena se finaliza
        if (posicion < 0)
        {
            return;
        }

        // Imprimimos la letra de la posicion actual
        Console.Write(cadena[posicion]);

        // Llamamos a la funcion con la siguiente posicion
        Invertir(cadena, posicion - 1);
    }
}