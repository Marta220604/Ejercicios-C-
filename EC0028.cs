class Program
{
    static void Main(string[] args)
    {
        //Calcula la suma de 1 a N usando un bucle for y despues con un foreach


        Console.WriteLine("Escribe un numero: ");
        int N = int.Parse(Console.ReadLine());

        int suma = 0;

        for (int i = 1; i <= N; i++)
        {
            suma = suma + i;
        }

        Console.WriteLine("La suma es: " + suma);
    }
}
