using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Lee de consola dos enteros y muestra la suma en formato: “a + b = resultado”.


        int num1;
        int num2;
        string input1;
        string input2;

        Console.WriteLine("Escribe el primer numero");
        input1 = Console.ReadLine();

        num1 = int.TryParse(input1, out num1) ? num1 : 0;

        Console.WriteLine("Escribe el segundo numero");
        input2 = Console.ReadLine();

        num2 = int.TryParse(input2, out num2) ? num2 : 0;

        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));

    }
}