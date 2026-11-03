class Program
{
    static void Main(string[] args)
    {

        //Frecuencia de letras. Dada una frase, cuenta cuántas veces aparece cada vocal (a,e,i,o,u) y muestra el resultado.EC0066
            
            String input;
            Console.WriteLine("Escribe una frase: ");
            input=Console.ReadLine();

            //contadores para cada vocal
            int contA=0;
            int contE=0;
            int contI=0;
            int contO=0;
            int contU=0;

            //convertimos la frase a mainusuculas
            input = input.ToLower();

            //contar cuantas veces aparece cada vocal
            //recorremos la frase


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]== 'a')
                {
                    contA++;
                }else if (input[i] ==  'e')
                {
                    contE++;
                }else if (input[i]== 'i')
                {
                    contI++;
                }else if (input[i]== 'o')
                {
                    contO++;
                }else if (input[i]== 'u')
                {
                    contU++;
                }
            }

            Console.WriteLine("La 'a' aparece: " + contA + " veces" + "\n" +
                              "La 'e' aparece: " + contE + " veces" + "\n" +
                              "La 'i' aparece: " + contI + " veces" + "\n" +
                              "La 'o' aparece: " + contO + " veces" + "\n" +
                              "La 'u' aparece: " + contU + " veces" + "\n");
            
        
    }
}