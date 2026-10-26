using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Pide al usuario un número y muestra por pantalla la tabla de multiplicar de ese número. 
        // No uses concatenación de cadenas, ni bucles, para mostrar el mensaje.

        Console.WriteLine("Escribe un numero: ");
        String input = Console.ReadLine();
        int num = int.TryParse(input, out num) ? num : 0;

        Console.WriteLine($"{num} x 0 = {num * 0}");
        Console.WriteLine($"{num} x 1 = {num * 1}");
        Console.WriteLine($"{num} x 2 = {num * 2}");
        Console.WriteLine($"{num} x 3 = {num * 3}");
        Console.WriteLine($"{num} x 4 = {num * 4}");
        Console.WriteLine($"{num} x 5 = {num * 5}");
        Console.WriteLine($"{num} x 6 = {num * 6}");
        Console.WriteLine($"{num} x 7 = {num * 7}");
        Console.WriteLine($"{num} x 8 = {num * 8}");
        Console.WriteLine($"{num} x 9 = {num * 9}");
        Console.WriteLine($"{num} x 10 = {num * 10}");
    }
}
