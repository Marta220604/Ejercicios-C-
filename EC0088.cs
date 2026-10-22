using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Solicita al usuario tres cantidades de 0 a 255 para definir un color en componentes rojo, verde y azul, convierte las 
        // tres cantidades en un entero y muestra el equivalente a ese color en notación hexadecimal.
    
         int rojo;
        int verde;
        int azul;
        string input;

        Console.WriteLine("Introduce la cantidad de rojo (0-255): ");
        input = Console.ReadLine();
        rojo = int.TryParse(input, out rojo) ? rojo : 0;

        Console.WriteLine("Introduce la cantidad de verde (0-255): ");
        input = Console.ReadLine();
        verde = int.TryParse(input, out verde) ? verde : 0;

        Console.WriteLine("Introduce la cantidad de azul (0-255): ");
        input = Console.ReadLine();
        azul = int.TryParse(input, out azul) ? azul : 0;

        Console.WriteLine("El color en hexadecimal es: #" + rojo.ToString("X2") + verde.ToString("X2") + azul.ToString("X2"));
    }
}