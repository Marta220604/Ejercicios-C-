class Program
{
    static void Main(string[] args)
    {
        // Crea un bucle para pedir al usuario que introduzca un número entero (int), 
        // en caso de introducirlo mal se le avisará 
        // y se le volverá a pedir. En caso de introducirlo bien se le dará las gracias.

        int numero;
        string input;

        Console.WriteLine("Escribe un numero entero: ");
        input = Console.ReadLine();

        while (!int.TryParse(input, out numero))
        {
            Console.WriteLine("Error, introduce un numero entero: ");
            input = Console.ReadLine();
        }

        Console.WriteLine("Gracias");
    }
}