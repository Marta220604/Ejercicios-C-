
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // Diferencia absoluta acumulada. Suma de |a[i] - a[i-1]| para i desde 1 hasta fin. 


        int[] numeros = { 2, 5, 3, 8 };
        int suma = 0;

        for (int i = 1; i < numeros.Length; i++)
        {
            suma += Math.Abs(numeros[i] - numeros[i - 1]);
        }

        Console.WriteLine($"La diferencia absoluta acumulada es: {suma}");
    }
}