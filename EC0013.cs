using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Lee dos enteros y muestra cuál es mayor o si son iguales. 
        double num1;
        double num2;

        Console.WriteLine("Escribe un numero: ");
        String input1 = Console.ReadLine();
        num1 = double.TryParse(input1, out num1) ? num1 : 0;

        Console.WriteLine("Escribe un numero: ");
        String input2 =  Console.ReadLine();
        num2 = double.TryParse(input2, out num2) ? num2 : 0;

        if (num1==num2)
        {
            Console.WriteLine("Son iguales");    
        }
        else if(num1>num2)
        {
            Console.WriteLine(num1 + " es mayor que " + num2);  
        }
        else
        {
            Console.WriteLine(num2 + " es mayor que " + num1);
        }

    }
}