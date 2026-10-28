class Program
{
    static void Main(string[] args)
    {
        // Solicita al usuario un número de una cifra y muestra por consola el número introducido con letras. 
        // Ej. 8 se mostraría como “Ocho”

        Console.WriteLine("Escribe un numero de una cifra: ");
        int numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 0:
                Console.WriteLine("Cero");
                break;
            case 1:
                Console.WriteLine("Uno");
                break;
            case 2:
                Console.WriteLine("Dos");
                break;
            case 3:
                Console.WriteLine("Tres");
                break;
            case 4:
                Console.WriteLine("Cuatro");
                break;
            case 5:
                Console.WriteLine("Cinco");
                break;
            case 6:
                Console.WriteLine("Seis");
                break;
            case 7:
                Console.WriteLine("Siete");
                break;
            case 8:
                Console.WriteLine("Ocho");
                break;
            case 9:
                Console.WriteLine("Nueve");
                break;
            default:
                Console.WriteLine("El numero debe ser de una cifra.");
                break;
        }
    }
}