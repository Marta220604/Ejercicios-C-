using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Solicita al usuario un entero y tras ello solicítale caracteres individuales (guárdalos como “char”)
        //  hasta completar el número dado. Posteriormente, 
        // imprime por consola una cadena que contenga todos los caracteres introducidos en orden inverso. 

        int num;

        Console.WriteLine("Escribe un numero entero: ");
        String input = Console.ReadLine();
        num = int.TryParse(input, out num) ? num : 0;

        char[] caracteres = new char[num];

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Escribe un caracter: ");
            caracteres[i] = Convert.ToChar(Console.ReadLine());
        }

        Console.WriteLine("Los caracteres en orden inverso son: ");

        for (int i = num - 1; i >= 0; i--)
        {
            Console.Write(caracteres[i]);
        }

        Console.WriteLine();
        
    }
}