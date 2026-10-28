class Program
{
    static void Main(string[] args)
    {
        //Crea tres variables enteras “numA”, “numB” y “resultado”. 
        // Úsalas para multiplicar “129070” por “20689” y mostrar el resultado. 
        // Comprueba si el resultado es el esperado.¿Por qué pasa eso?


        int numA= 129070;
        int numB = 20689;
        int resultado = numA * numB;

        Console.WriteLine("resultado: " + resultado);

        // El resultado es incorrecto porque el tipo int no puede almacenar un número tan grande.
        // Un int de 32 bits con signo tiene un valor máximo de 2147483647 y el resultado supera ese límite.
        // Esto provoca un desbordamiento (overflow).
    }
}
