using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Solicita al usuario un alto y un ancho e
        //  imprime por consola un cuadrado de asteriscos con esas dimensiones. 
        // Ej: alto 2 y ancho 5: ***** ***** .

        int alto;
        int ancho;

        Console.WriteLine("Escribe un alto: ");
        String input1 = Console.ReadLine();
        alto = int.TryParse(input1, out alto) ? alto : 0;

        Console.WriteLine("Escribe un ancho: ");
        String input2 =  Console.ReadLine();
        ancho = int.TryParse(input2, out ancho) ? ancho : 0;

        for (int i = 0; i < alto ; i++)
        {
            for (int j = 0; j < ancho; j++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }

    }
}