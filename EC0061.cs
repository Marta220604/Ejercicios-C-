using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // Media sin extremos. 
        // Dado un array de enteros (al menos 3), calcula la media sin contar el min y el max. EC0061

         int[] numeros = { 2, 4, 6, 8, 10 };

        int min = numeros[0];
        int max = numeros[0];
        int suma = 0;

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

            suma += numeros[i];
        }

        suma = suma - min - max;

        double media = (double)suma / (numeros.Length - 2);

        Console.WriteLine($"La media sin extremos es: {media}");
    }
}