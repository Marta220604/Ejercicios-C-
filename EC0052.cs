using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
       
        //Detección de duplicados. 
        // Indica si hay algún valor repetido (doble bucle simple). HAzlo de 3 formas distintas. 
        // Investiga la librería LINQ y HashSet 

     
        int[] numeros = { 4, 7, 2, 7, 9 };

        // Primera forma: doble bucle simple
        int repetidos = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[j] == numeros[i])
                {
                    repetidos++;
                }
            }
        }

        if (repetidos > 0)
        {
            Console.WriteLine("Hay " + repetidos + " parejas repetidas.");
        }
        else
        {
            Console.WriteLine("No hay ningún repetido.");
        }

        // Segunda forma: LINQ
        bool hayDuplicadosLINQ =
            numeros.Length != numeros.Distinct().Count();

        if (hayDuplicadosLINQ)
            Console.WriteLine("LINQ: Hay valores duplicados.");
        else
            Console.WriteLine("LINQ: No hay valores duplicados.");

        // Tercera forma: HashSet
        HashSet<int> vistos = new HashSet<int>();
        bool hayDuplicadosHashSet = false;

        foreach (int numero in numeros)
        {
            if (!vistos.Add(numero))
            {
                hayDuplicadosHashSet = true;
                break;
            }
        }

        if (hayDuplicadosHashSet)
            Console.WriteLine("HashSet: Hay valores duplicados.");
        else
            Console.WriteLine("HashSet: No hay valores duplicados.");
    
    
    }
}