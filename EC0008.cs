using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
         // Lee de consola tres enteros y muestra la suma en formato: “a + b + c = resultado”.
        //  Usa un método de conversión para cada variable. Convert, Parse y TryParse. 
       

        int num1;
        int num2;
        int num3;
        string input1;
        string input2;
        string input3;

        Console.WriteLine("Escribe el primer numero");
        input1 = Console.ReadLine();

        num1 = Convert.ToInt32(input1);

        Console.WriteLine("Escribe el segundo numero");
        input2 = Console.ReadLine();

        num2 = int.Parse(input2);

        Console.WriteLine("Escribe el tercer numero");
        input3 = Console.ReadLine();

        num3 = int.TryParse(input3, out num3) ? num3 : 0;

        Console.WriteLine(num1 + " + " + num2 + " + " + num3 + " = " + (num1 + num2 + num3));

    }
}
