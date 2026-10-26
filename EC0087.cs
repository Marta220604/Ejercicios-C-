using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Muestra por pantalla la lista de los primeros 100 números 
        // naturales usando tres caracteres para cada uno (001, 002, 003…). (usa formatos).

        
        for (int i = 0; i < 101; i++)
        {
            Console.WriteLine($"{i:D3}");
        }

    }
}