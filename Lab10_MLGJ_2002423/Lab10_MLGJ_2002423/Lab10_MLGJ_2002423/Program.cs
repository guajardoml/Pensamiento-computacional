using System.Reflection;
using System.Runtime.CompilerServices;

class program
{
    static void Main(String[] args)
    {
        //Calculadora calc = new Calculadora();
        //Console.WriteLine("Semana 12- Funciones y procedimientos");
        //Console.WriteLine("Ingrese un numemro");
        //int num1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Ingrese otro numero");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        ////int resultado_suma = suma(num1, num2);
        ////Console.WriteLine("Suma = " + num1 + "+ " + num2 + " = " + resultado_suma);
        ////resta(num1, num2);
        //int suma = calc.suma(num1,num2);
        //Console.WriteLine("Resta =" + num1 + "- " + num2 + " = " + suma);
        //calc.resta(num1,num2 );
        
        
        Console.WriteLine("Semana 12- Funciones y procedimientos");
        Console.WriteLine("Por favor ingrese el radio del ciruclo: ");
        Circulo objCirculo = new Circulo(Convert.ToDouble(Console.ReadLine()));
        double perimetro=0;
        double area=0;
        double volumen=0;
        objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);
        Console.WriteLine("Perimetro:"+perimetro);
        Console.WriteLine("Area:" + area);
        Console.WriteLine("Volumen:" + volumen);


        Console.ReadKey();


    }

    public class Circulo
    {
        private double radio { get; set; }

        public Circulo(double radio)
        {
            this.radio = this.radio;
        }

        private double ObtenerPerimetro()
        {
            double pi = 3.1416;
            double perimetro = 2 * pi * radio;
            return perimetro;
        }
        private double ObtenerArea()
        {
            double pi = 3.1416;
            double area = pi * (Math.Pow(radio,2));
            return area;
        }
        private double ObtenerVolumen()
        {
            double pi = 3.1416;
            double volumen = (4* pi * Math.Pow(radio,3))/3;
            return volumen;
        }
        public void CalcularGeometria(ref double UnPerimetro, ref double UnArea, ref double UnVolumen)
        {
            UnPerimetro = ObtenerPerimetro();
            UnArea = ObtenerArea();
            UnVolumen = ObtenerVolumen();
            

        }



    }
    //static int suma(int a, int b)
    //{
    //    int suma = a + b;
    //    return suma;
    //}
    //static void resta(int a, int b)
    //{
    //    int resta = a - b;
    //    Console.WriteLine("Resta = " + a + "- " + b + " = " + resta);

    //}


    //public class Calculadora
    //{
    //    public int dato1 { get; set; }

    //    public Calculadora()
    //    {
    //        this.dato1 = 0;
    //    }

    //    public int suma(int a, int b)
    //    {
    //        int suma = a + b;
    //        return suma;
    //    }
    //    public void resta(int a, int b)
    //    {
    //        int resta = a - b;
    //        Console.WriteLine("Reesta = " + a + "- " + b + " = " + resta);

    //    }

    //}
}