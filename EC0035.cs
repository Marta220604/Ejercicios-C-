class Program
{
    static void Main(string[] args)
    {
        // Contar vocales. Cuenta cuántas vocales (a,e,i,o,u) tiene una cadena (ignorar mayúsculas).

        Console.WriteLine("Escribe una frase: ");
        string frase = Console.ReadLine().ToLower();

        int vocales = 0;

        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
            {
                vocales++;
            }
        }

        Console.WriteLine("La cadena tiene " + vocales + " vocales.");
    }
}