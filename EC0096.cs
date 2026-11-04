
class Program
{
    static void Main(string[] args)
    {
        //  Amplía el ejercicio EC0095 para que una vez introducidos los nombres se permita al usuario buscar un nombre en la lista. Si el nombre no se encuentra, 
        // se indicará al usuario que ese nombre no está en la lista y si se encuentra se mostrarán en pantalla el nombre y su posición en la lista. (Usa la búsqueda binaria)


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

         // Pedimos el nombre que queremos buscar
        Console.WriteLine("\n¿Qué nombre quieres buscar?");
        string buscar = Console.ReadLine();

        // Variables para realizar la busqueda binaria
        int inicio = 0;
        int fin = contador - 1;
        int medio;
        int encontrado = -1;

        // Buscamos mientras queden posiciones por comprobar
        while (inicio <= fin)
        {
            medio = (inicio + fin) / 2;

            // Comparamos el nombre buscado con el nombre del medio
            int comparacion = buscar.ToLower().CompareTo(nombres[medio].ToLower());

            if (comparacion == 0)
            {
                // El nombre se ha encontrado
                encontrado = medio;
                break;
            }
            else if (comparacion > 0)
            {
                // El nombre buscado es mayor, buscamos en la mitad derecha
                inicio = medio + 1;
            }
            else
            {
                // El nombre buscado es menor, buscamos en la mitad izquierda
                fin = medio - 1;
            }
        }

        // Comprobamos si hemos encontrado el nombre
        if (encontrado != -1)
        {
            Console.WriteLine("Nombre encontrado: " + nombres[encontrado]);
            Console.WriteLine("Posicion: " + encontrado);
        }
        else
        {
            Console.WriteLine("El nombre no está en la lista.");
        }
    }
}
