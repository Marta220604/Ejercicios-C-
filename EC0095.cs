
class Program
{
    static void Main(string[] args)
    {
        // EC0095. +EC0095: Crea un programa que pida al usuario nombres y los vaya almacenando en un array en orden alfabético hasta un máximo de 100
        //  o que el usuario introduzca una cadena vacía. Finalmente, muestra la lista de nombres.

        string[] nombres = new string[100];

        int contador = 0;
        string nombre;

        // Pedimos nombres hasta que se introduzca una cadena vacia o lleguemos a 100
        while (contador < 100)
        {
            Console.WriteLine("Introduce un nombre: ");
            nombre = Console.ReadLine();

            // Si escribe una cadena vacia se sale del bucle
            if (nombre == "")
            {
                break;
            }

            // Buscamos donde colocar el nombre
            int posicion = contador;

            for (int i = 0; i < contador; i++)
            {
                //Si el compareTo da menos de 0 el primer nombre que se compara va antes por lo tanto ocupa esa posicion en la lista
                if (nombre.ToLower().CompareTo(nombres[i].ToLower()) < 0)
                {
                    posicion = i;
                    break;
                }
            }

            // Desplazamos los nombres para dejar espacio
            for (int i = contador; i > posicion; i--)
            {
                nombres[i] = nombres[i - 1];
            }

            // Colocamos el nuevo nombre
            nombres[posicion] = nombre;

            contador++;
        }

        // Mostramos los nombres ordenados
        Console.WriteLine("\nLista de nombres:");

        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine(nombres[i]);
        }
    }
}
