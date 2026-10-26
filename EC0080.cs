using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Solicita un carácter al usuario y muestra por pantalla si se trata de un número (del 0 al 9), 
        // un signo de puntuación entre (.,;:) o de otro carácter. (usa un switch).

        Console.WriteLine("Escribe un numero: ");
        String input = Console.ReadLine();

        switch (input)
       {
            //aqui string when indica que el case se aplica a un texto cuando se cumple la condición.
            case string when input.Length == 1 && input[0] >= '0' && input[0] <= '9':
                Console.WriteLine("Es un numero");
                break;

            case ".":
            case ",":
            case ";":
            case ":":
                Console.WriteLine("Es un signo de puntuacion");
                break;

            default:
                Console.WriteLine("Es otro caracter");
                break;
        }

    }
}