class Program
{
    static void Main(string[] args)
    {
        // Palíndromo. Lee una palabra/frase y determina si es palíndroma (ignorar espacios y mayúsculas)

        Console.WriteLine("Escribe una palabra o frase: ");
        string frase = Console.ReadLine().ToLower().Replace(" ", "");

        bool palindromo = true;

         // Recorremos la frase hasta llegar a la mitad
        for (int i = 0; i < frase.Length / 2; i++)
        {
            // Comparamos el caracter de la posicion actual con el carácter de la pscion contraria
            // frase[i] empieza por la izquierda
            // frase[frase.Length - 1 - i] empieza por la derecha
            if (frase[i] != frase[frase.Length - 1 - i])
            {
                //si no son iguales los caracteres se cambia la variable a false
                palindromo = false;
            }
        }

        if (palindromo)
        {
            Console.WriteLine("Es palindromo");
        }
        else
        {
            Console.WriteLine("No es palindromo");
        }
    }
}