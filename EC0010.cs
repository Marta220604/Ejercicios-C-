using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Crea un programa que pida al usuario dos números enteros y muestre por pantalla
        //tanto el resultado de dividir el primero por el segundo, y el resto de esa división. 

        Console.WriteLine("Escribe el primer numero: ");
        String input1 = Console.ReadLine();
        int num1 = int.TryParse(input1, out num1) ? num1 : 0;

        Console.WriteLine("Escribe el segundo numero: ");
        String input2 = Console.ReadLine();
        int num2 = int.TryParse(input2, out num2) ? num2 : 0;

        Console.WriteLine("Resultado de la division: " + (num1/num2));
        Console.WriteLine("Resultado de la division: " + (num1%num2));

       

    }
}