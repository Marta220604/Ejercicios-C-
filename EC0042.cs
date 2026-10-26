using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Mínimo y máximo en array. Recorre el array y determina min y max (sin funciones LINQ aún)

        int[] numeros = { 8, 3, 15, 2, 10, 6 };

        int min = numeros[0];
        int max = numeros[0];

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] < min)
            {
                min = numeros[i];
            }

            if (numeros[i] > max)
            {
                max = numeros[i];
            }
        }

        Console.WriteLine($"El minimo es: {min}");
        Console.WriteLine($"El maximo es: {max}");
    }
}