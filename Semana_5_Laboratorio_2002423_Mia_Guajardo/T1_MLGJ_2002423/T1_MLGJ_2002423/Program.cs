class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mi segundo programa ");

        string sNombre;
        sbyte sEdad;
        string sCarrera;
        string SCarne;

        Console.WriteLine("Ingrese su nombre: ");
        sNombre = Console.ReadLine();

        Console.WriteLine("Ingrese su edad: ");
        sEdad = sbyte.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese se carrera: ");
        sCarrera = Console.ReadLine();

        Console.WriteLine("Ingrese su carne de la universidad: ");
        SCarne = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("Nombre: " + sNombre);
        Console.WriteLine("Edad: " + sEdad);
        Console.WriteLine("Carrera: " + sCarrera);
        Console.WriteLine("Carne: " + SCarne);

        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("Soy " + sNombre + ", tengo " + sEdad + " años y estudio la carrera de " + sCarrera + ", mi numero de carne es: " + SCarne);

        Console.ReadKey();



    }
}
