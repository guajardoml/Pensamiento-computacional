class Program
{
    static void Main(string[] args)
    {
        int opcionmen = 0;
        
        do
        {


            Console.WriteLine("Por favor Ingrese 7 numeros enteros");
            int[] numeros = new int[7];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Numero: ");
                numeros[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("El numero mayor ingresado es: " + numeros.Max());
            Console.WriteLine("El numero menos ingresado es: " + numeros.Min());
            int positivos = 0;
            int negativos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    positivos++;
                }
                else
                {
                    negativos++;
                }
            }

            Console.WriteLine("Usted ingreso {0} numeros positivos", positivos);
            Console.WriteLine("Usted ingreso {0} numeros negativos", negativos);

            Console.WriteLine("Desea ingresar otra secuencia de numeros?");
            Console.WriteLine("Si lo desea, presiones 0, si no lo desea, presione 1.");
            opcionmen = Convert.ToInt16(Console.ReadLine());
            if (opcionmen == 1)
            {
                Console.WriteLine("Usted ingreso los siguiente numeros");
                for (int i = 0; i < numeros.Length; i++) {
                    Console.WriteLine(numeros[i]);
                }
            }
        } while (opcionmen == 0);

        

    }
}