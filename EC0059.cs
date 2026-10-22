using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Pide un precio sin IVA (double). Calcula el precio final con IVA 21%.

        Console.WriteLine("Escribe un precio sin IVA: ");
        String input = Console.ReadLine();
        double precio = double.TryParse(input, out precio) ? precio:0;

        Console.WriteLine("Precio con IVA: " + (precio * (1 + 0.21)));
    }
}