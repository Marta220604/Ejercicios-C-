
class Program
{
    static void Main(string[] args)
    {
        //Lee tres enteros y muestra el menor y el mayor (sin usar aún arrays).

        Console.WriteLine("Escribe el primer numero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Escribe el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Escribe el tercer numero: ");
        int num3 = int.Parse(Console.ReadLine());

        int mayor = num1;
        int menor = num1;

        if (num2 > mayor)
        {
            mayor = num2;
        }
        else if (num2 < menor)
        {
            menor = num2;
        }

        if (num3 > mayor)
        {
            mayor = num3;
        }
        else if (num3 < menor)
        {
            menor = num3;
        }
        Console.WriteLine("El mayor es: " + mayor);
        Console.WriteLine("El menor es: " + menor);
    }
}