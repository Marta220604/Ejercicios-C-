using System;
using System.Globalization;

class Program
{
    static string name ="";

    static void Main(String [] args)
    {
        double num = 123.2344;
        double porcentaje = 0.1234;

        Console.WriteLine($"(num:F3)");
        Console.WriteLine(num.ToString("F3"));
        Console.WriteLine($"(porcentaje: P2)");


        Console.Write("Ingresa un numero: ");
        String input = Console.ReadLine().Trim();

    //dos formas de hacer el parse el primero da excepcion el otro si es false daria 0
        int numero = int.Parse(input);

         numero = int.TryParse(input, out int result) ? result : 0;
        Console.WriteLine($"EL numero ingresado es: {numero}");
        

    } 
}