class Program
{
    static void Main(string[] args)
    {
        // Crear array de 5 enteros. Declara int[] nums = new int[5]; pide 5 valores y 
        // luego los imprime separados por comas.

        int[] nums = new int[5];

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine("Escribe un numero: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i]);

            if (i < nums.Length - 1)
            {
                Console.Write(", ");
            }
        }
    }
}