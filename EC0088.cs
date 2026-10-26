using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Solicita al usuario tres cantidades de 0 a 255 para definir un color en 
        // componentes rojo, verde y azul, convierte las tres cantidades en un entero y
        //  muestra el equivalente a ese color en notación hexadecimal. 
        // Usa operadores de bits, para desplazar los bits a las posiciones altas(>>) y 
        // para dejar 1 donde alguno de los números tenga 1 (or de bits) 
        // 255 son 8 bits, por lo que necesitas 24 bits si vas a unir r g b.
        //  Elije el mejor tipo de número para tener 24 bits.
        // Para mostrarlo en hexadecimal se puede darle formato al número con num:__ 
    
         
        int rojo;
        int verde;
        int azul;
        string input;

        Console.WriteLine("Introduce la cantidad de rojo (0-255): ");
        input = Console.ReadLine();
        rojo = int.TryParse(input, out rojo) ? rojo : 0;

        Console.WriteLine("Introduce la cantidad de verde (0-255): ");
        input = Console.ReadLine();
        verde = int.TryParse(input, out verde) ? verde : 0;

        Console.WriteLine("Introduce la cantidad de azul (0-255): ");
        input = Console.ReadLine();
        azul = int.TryParse(input, out azul) ? azul : 0;


        // Desplazamos el rojo 16 posiciones porque tiene que dejar espacio para el verde y el azul (8 + 8).
        // Desplazamos el verde 8 posiciones porque tiene que dejar espacio para el azul.
        // El azul no se desplaza porque ya está en su sitio.
        // Usamos | para unir los tres colores en un solo número.
        int color = (rojo << 16) | (verde << 8) | azul;

        //X indica que se quiere mostrar en hexadecimal y 6 que es uun minimo de  cifras 
        Console.WriteLine($"El color en hexadecimal es: {color:X6}");
    }
}
