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

        for(int i = 0; i<=10; i++)
        {
            Console.WriteLine(num + " x " + i +" = " + (num*i));
        }
    }
}