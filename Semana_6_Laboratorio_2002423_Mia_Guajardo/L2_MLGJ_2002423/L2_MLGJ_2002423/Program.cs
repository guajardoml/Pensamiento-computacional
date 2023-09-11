class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio 2");
        Console.WriteLine("Ingrese el numero de dia: ");
        double numero = double.Parse(Console.ReadLine());

        if ( numero <= 0 || numero > 7)
        {
            Console.WriteLine("Error: el numero a ingresar debe estar contenido entre 1 y 7.");
        }

        if ( numero == 1)
        {
            Console.WriteLine("DIA: DOMINGO");
        }
        else if (numero == 2)
        {
            Console.WriteLine("DIA: LUNES");
        }
        else if (numero == 3)
        {
            Console.WriteLine("DIA: MARTES");
        }
        else if (numero == 4)
        {
            Console.WriteLine("DIA: MIERCOLES");
        }
        else if (numero == 5)
        {
            Console.WriteLine("DIA: JUEVES");
        }
        else if (numero == 6)
        {
            Console.WriteLine("DIA: VIERNES");
        }
        else if (numero == 7)
        {
            Console.WriteLine("DIA: SABADO");
        }

        Console.ReadKey();

    }

}