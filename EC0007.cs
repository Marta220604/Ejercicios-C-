class Program
{
    static void Main(string[] args)
    {
        //Pide por consola el nombre por consola y muestra: “Hola, <nombre>”.

        String nombre;

        Console.WriteLine("Escribe un nombre: ");
        nombre = Console.ReadLine();

        Console.WriteLine("Hola, " + nombre);
    }
}