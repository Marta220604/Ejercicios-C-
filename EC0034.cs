class Program
{
    static void Main(string[] args)
    {
        // Primera y última letra. De una cadena no vacía, muestra el primer y último carácter. EC0034

        Console.WriteLine("Escribe una palabra: ");
        string palabra = Console.ReadLine();

        Console.WriteLine("La primera letra es: " + palabra[0]);
        Console.WriteLine("La ultima letra es: " + palabra[palabra.Length - 1]);
    }
}