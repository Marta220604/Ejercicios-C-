class Program
{
    static void Main(string[] args)
    {
        //Calcula mentalmente y anota el resultado de a=3; b=++a; c=a++; b=b*3; a=a*2;
        // Verifica con un programa los resultados.

        int a=3;
        int b = ++a;
        int c=a++;

        Console.WriteLine("primeros valores: ");
        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);
        Console.WriteLine("c: " + c);

         b=b*3; 
         a=a*2;


        Console.WriteLine("segundos valores: ");
        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);
        Console.WriteLine("c: " + c);
    }
}