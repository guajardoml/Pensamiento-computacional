class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("EJERCICIOS POR MIA GUAJARDO 2002423");
        Console.WriteLine("ejercicio 1: operaciones aritmeticas");

        Console.WriteLine("Ingrese un numero entero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un numero entero: ");
        int num2 = int.Parse(Console.ReadLine());

        int suma = num1 + num2;
        Console.WriteLine("La suma entre " + num1 + " y " + num2 + " es igual a " + suma);

        int resta = num1 - num2;
        Console.WriteLine("La resta entre " + num1 + " y " + num2 + " es igual a " + resta);

        int multi = num1 * num2;
        Console.WriteLine("La multiplicacion entre " + num1 + " y " + num2 + " es igual a " + multi);

        int div = num1 / num2;
        Console.WriteLine("La division entre " + num1 + " y " + num2 + " es igual a " + div);

        int resi = num1 % num2;
        Console.WriteLine("El residuo de la division entre " + num1 + " y " + num2 + " es igual a " + resi);

        Console.WriteLine("Presione cualquier tecla para pasar al siguiente ejercicio: ");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("ejercicio 2: operaciones booleanas");
        switch (num1, num2)
        {
            case ( > 0, > 0) when (num1 == num2):
                Console.WriteLine("Resultado: ambos numeros son iguales.");
                break;
            case ( > 0, > 0) when (num1 > num2):
                Console.WriteLine("Resultado: el primer numero ingresado es mayor al segundo.");
                break;
            case ( > 0, > 0) when (num1 < num2):
                Console.WriteLine("Resultado: el primer numero ingresado es menor al segundo.");
                break;

        }

        Console.WriteLine("Presione cualquier tecla para pasar al siguiente ejercicio: ");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("ejercicio 3: jerarquia de operaciones");

        Console.WriteLine("Ingrese un numero entero a: ");
        int num3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un numero entero b: ");
        int num4 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un numero entero c: ");
        int num5 = int.Parse(Console.ReadLine());

        Console.WriteLine("La operacion a realizar es: (3a+2b)/c^2");
        double resultado = (3*num3+2*num4)/Math.Pow(num5,2);
        Console.WriteLine("El resultado es " + resultado);

        Console.ReadKey();
    }

}
