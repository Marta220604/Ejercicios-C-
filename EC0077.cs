using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Pide continuamente números al usuario hasta encontrar
        //  uno que sea múltiplo de 2, 3 y 7 simultáneamente.

        int  num;
        do
        {
            Console.WriteLine("Escribe un numero: ");
            String input = Console.ReadLine();
            num = int.TryParse(input, out num) ? num : 0;
        } while (num % 2 != 0 || num % 3 != 0 || num % 7 != 0);

    }
}