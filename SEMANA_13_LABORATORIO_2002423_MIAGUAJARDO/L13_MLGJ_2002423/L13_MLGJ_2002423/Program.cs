using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //int[] vector = new int[5];
        //string[] vector2 = new string[5];

        //string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };

        //for (int i = 0; i < dias.Length; i++) 
        //{
        //    Console.WriteLine(dias[i]);
        //}

        // PRIMER EJERCICIO
        double[] notas = new double[8];
        double suma = 0;
        double promedio = 0;
        for (int i = 0; i < notas.Length; i++)
        {

            Console.WriteLine("Ingrese una nota: ");
            notas[i] = Convert.ToInt32(Console.ReadLine());
            suma += (double)notas[i];

            promedio = suma / (double)notas.Length;

        }
        Console.WriteLine("El promedio es de: " + promedio);
        Console.WriteLine("La mayor de las notas ingresadas es:" + notas.Max());

        //SEGUNDO EJERCICIO
        Console.WriteLine();
        Console.WriteLine("Por favor ingrese una palabra: ");
        string palabra = Console.ReadLine();
        palabra = palabra.ToLower();
        palabra = palabra.Trim();
        
        Console.WriteLine("Por favor ingrese una letra minuscula: ");
        char letra = Convert.ToChar(Console.ReadLine());

        int numero = 0;
        for (int i = 0; i<palabra.Length; i++)
        {
            if (palabra[i]==letra)
            {
                
                numero++;
            }

        }
        if (numero >= 1)
        {
            Console.WriteLine("La palabra ingresada contiene " + letra + " " + numero + " vez/veces. ");
        }
        else
        {
            Console.WriteLine("El caracter ingresado no esta contenido en la palabra. ");
        }

        Console.ReadKey();




    }
}