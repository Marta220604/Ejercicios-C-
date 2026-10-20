class Program
{
    static void Main(string[] args)
    {
        //Crea un programa que calcule la división entre los números enteros 321 y 
        // 698 usando dos variables llamadas “1entero” y “2entero”. 
        // Guarda el resultado en otra variable y muestralo por consola con 3 decimales

        int entero1 = 321;
        int entero2 = 698;
        double resultado = entero2/entero1;

        Console.WriteLine($"EL resultado es:  {resultado:F3}");
    }
}