class Program
{
    static void Main(string[] args)
    {
        int resultado = potencia(2, 3);

        Console.WriteLine("El resultado es: " + resultado);
    }

    static int potencia(int numero, int exponente)
    {
        
        if (exponente == 0)
        {
            return 1;
        }

       
        return numero * potencia(numero, exponente - 1);
    }
}