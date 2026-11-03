
class Program
{
    static void Main(string[] args)
    {

        //Crea un programa que almacene en un array los días de cada mes del año (no bisiesto) y luego pida al usuario un mes y 
        // el número de día del mes. El programa devolverá el día del año. [Ej: 3 de febrero → Día 34 del año

        // EC0091.  Ejercicio A04_03: Amplía el ejercicio anterior para que el usuario introduzca dos fechas dentro del mismo año y 
        // devuelva el número de días entre ellas. [Ej: 10 de enero y 3 de febrero --> 24 días

        // Array con los dias de cada mes 
        int[] diasMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int mes1, dia1;
        int mes2, dia2;

        // Pedimos la primera fecha
        Console.WriteLine("Introduce el primer mes (1-12): ");
        mes1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el primer dia: ");
        dia1 = int.Parse(Console.ReadLine());

        // Pedimos la segunda fecha
        Console.WriteLine("Introduce el segundo mes (1-12): ");
        mes2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo dia: ");
        dia2 = int.Parse(Console.ReadLine());

        // Calculamos el dia del año de la primera fecha
        int diaAnual1 = dia1;

        for (int i = 0; i < mes1 - 1; i++)
        {
            diaAnual1 = diaAnual1 + diasMes[i];
        }

        // Calculamos el dia del año de la segunda fecha
        int diaAnual2 = dia2;

        for (int i = 0; i < mes2 - 1; i++)
        {
            diaAnual2 = diaAnual2 + diasMes[i];
        }

        // Calculamos los días entre las dos fechas
        int diferencia;

        if (diaAnual1 > diaAnual2)
        {
            diferencia = diaAnual1 - diaAnual2;
        }
        else
        {
            diferencia = diaAnual2 - diaAnual1;
        }

        Console.WriteLine("Hay " + diferencia + " dias entre las dos fechas.");
    }
}
