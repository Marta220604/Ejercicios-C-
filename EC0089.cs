
class Program
{
    static void Main(string[] args)
    {
        //Solicita al usuario diez números double y almacénalos en un vector, 
        // posteriormente muestra por pantalla la media, la moda (número que más se repite) de la parte entera
        //  y todos los números que sean inferiores a la media.

        List<double> listaNumeros = new List<double>();

        //pedimos por consola 10 numeros y los agregamos a la lista

        String input;
        double numero;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Escribe un numero: "); 
            input =Console.ReadLine();
            if (double.TryParse(input, out numero))
            {
                listaNumeros.Add(numero);
            }
            else
            {
                Console.WriteLine("Número no válido");
                i--;
            }
        }

        //creamos el vector/array y le pasamos la lista con todos los numeros ya añadidos
        double [] vectorNumeros = listaNumeros.ToArray();

        //Mostrar por pantalla la media
        double suma = 0;
        foreach (double numeroActual in vectorNumeros)
        {
            suma += numeroActual;
        }

        double media = suma/vectorNumeros.Length;
        Console.WriteLine("La media es: " + (media));

        //Mostrar la moda por pantalla

        int moda = 0;
        int maxRepeticiones = 0;

        for (int i = 0; i < vectorNumeros.Length; i++)
        {
            int numeroActual = (int)vectorNumeros[i];
            int repeticiones = 0;

            for (int j = 0; j < vectorNumeros.Length; j++)
            {
                if ((int)vectorNumeros[j] == numeroActual)
                {
                    repeticiones++;
                }
            }

            if (repeticiones > maxRepeticiones)
            {
                maxRepeticiones = repeticiones;
                moda = numeroActual;
            }
        }

        Console.WriteLine("La moda de la parte entera es: " + moda);

        //todos los numeros que sean inferiores a la media
        Console.WriteLine("Los numero mas pequeños que la media son: ");
        for (int i = 0; i < vectorNumeros.Length; i++)
        {
            if (vectorNumeros[i] < media)
            {
                Console.WriteLine(vectorNumeros[i] + " ");                
            }
        }
    }
}