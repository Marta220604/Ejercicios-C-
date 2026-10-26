using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Redondeo de lista de decimales. 
        // Crea un array de double (manual), y muestra cada valor redondeado a 2 decimales

        double [] lista = [8.8478, 8.04, 6.3442, 2.3210, 3.4, 9.0, 23.321348] ;

        foreach (double numero in lista)
        {
            Console.WriteLine($"{numero:F2}");
        }
        
    }
}