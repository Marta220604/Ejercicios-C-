using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Crea un programa que imprima por consola el
        // resultado de las siguientes operaciones matemáticas:
        //  “-8 + 6 * 3”, “(2 + 7) % 5” y “2 + ( -1 * 8 ) -5 % 3”. Usa variables. 

        int primeraOp = -8 + 6 * 3;
        int segundaOp = (2 + 7) % 5;
        int terceraOp = 2 + ( -1 * 8 ) -5 % 3;

        Console.WriteLine("-8 + 6 * 3: " + primeraOp);
        Console.WriteLine("(2 + 7) % 5: " + segundaOp);
        Console.WriteLine("2 + ( -1 * 8 ) -5 % 3: " + terceraOp);
    }
}