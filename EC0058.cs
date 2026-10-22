using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Lee un entero y muestra su último dígito (usar valor absoluto y resto dividir 10). 
    
        int numero;
        string input;

        Console.WriteLine("Escribe un numero entero: ");
        input = Console.ReadLine();

        numero = int.TryParse(input, out numero) ? numero : 0;

        Console.WriteLine("El ultimo digito es " + (Math.Abs((long)numero) % 10));
    }
}