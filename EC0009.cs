using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Crea un programa que pida al usuario
        //  una distancia en metros y la conviertaa millas (1 milla = 1609 metros). 

        double metros;
        String input;

        Console.WriteLine("Escribe una medida en metros: ");
        input=Console.ReadLine();

        metros = double.TryParse(input, out metros) ? metros : 0;

        Console.WriteLine(metros + " metros son " + (metros/1609) + " millas");


       

    }
}