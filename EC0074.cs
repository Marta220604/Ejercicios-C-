using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {

        //Mini menú interactivo. Muestra un menú (1=Agregar número a array dinámico, 2=Listar, 3=Mostrar promedio, 4=Salir). 
        // Implementa bucle while y un switch (si ya lo habéis visto; si no, usar if encadenados). 
        // (El array puede simularse con un tamaño fijo y un contador, cuando no quepan más número se avisará al usuario.)

        int opcion = 0;


        int[] numeros = new int[5];

        int contador = 0;

        do
        {
            Console.WriteLine("1 - Agregar numero a array dinamico \n 2 - Lista \n 3 - Mostrar promedio \n 4 - Salir ");
            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:

                    if (contador < numeros.Length)
                    {
                        Console.WriteLine("Introduce un numero: ");
                        numeros[contador] = int.Parse(Console.ReadLine());

                        
                        contador++;

                        Console.WriteLine("Numero agregado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("El array esta lleno.");
                    }

                    break;

                case 2:

                    
                    if (contador > 0)
                    {
                        Console.WriteLine("Numeros guardados:");

                        for (int i = 0; i < contador; i++)
                        {
                            Console.WriteLine(numeros[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Todavia no hay numeros.");
                    }

                    break;

                case 3:

                    if (contador > 0)
                    {
                        int suma = 0;

                        for (int i = 0; i < contador; i++)
                        {
                            suma = suma + numeros[i];
                        }

                        double promedio = (double)suma / contador;

                        Console.WriteLine("El promedio es: " + promedio);
                    }
                    else
                    {
                        Console.WriteLine("No hay numeros para calcular el promedio.");
                    }

                    break;

                case 4:

                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:

                    Console.WriteLine("Opcion no valida.");
                    break;
            }



        } while (opcion != 4);

    }
}