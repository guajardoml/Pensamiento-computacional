using System.Reflection;
using System.Runtime.CompilerServices;

class program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Por favor ingrese una opcion del menu \n presione 1 para trabajr con un circulo \n presione 2 para resolver un triangulo");
        int menu = Convert.ToInt16(Console.ReadLine());
        switch (menu)
        {
            case 1:
                Console.WriteLine("Semana 12- Funciones y procedimientos");
                Console.WriteLine("Por favor ingrese el radio del circulo: ");
                Circulo objCirculo = new Circulo(Convert.ToDouble(Console.ReadLine()));
                double perimetro = 0;
                double area = 0;
                double volumen = 0;
                objCirculo.CalcularGeometria(ref perimetro, ref area, ref volumen);
                Console.WriteLine("Perimetro:" + perimetro);
                Console.WriteLine("Area:" + area);
                Console.WriteLine("Volumen:" + volumen);



                Console.ReadKey();
                break;
            case 2:
                Console.WriteLine("Ingrese el cateto A y el angulo opuesto de A (EN GRADOS), en diferentes lineas ");
                TrianguloRectangulo objTriangulo = new TrianguloRectangulo(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("\n");
                Console.WriteLine("El cateto A es: "+objTriangulo.ObtenerCatetoA() +"\nEl cateto B es: "+objTriangulo.ObtenerCatetoB()+"\nEl valor de la hipotenusa es: "+objTriangulo.ObtenerHipotenusa()+"\nEl valor del angulo opuesto de A es: "+objTriangulo.ObtenerAnguloOpuestoA()+"\nEl valor del angulo opuesto de B es: "+objTriangulo.ObtenerAnguloOpuestoB()+"\nEl valor del area es: "+objTriangulo.ObtenerArea());
                Console.ReadKey();
                break;
        }

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
            double area = pi * (Math.Pow(radio, 2));
            return area;
        }
        private double ObtenerVolumen()
        {
            double pi = 3.1416;
            double volumen = (4 * pi * Math.Pow(radio, 3)) / 3;
            return volumen;
        }
        public void CalcularGeometria(ref double UnPerimetro, ref double UnArea, ref double UnVolumen)
        {
            UnPerimetro = ObtenerPerimetro();
            UnArea = ObtenerArea();
            UnVolumen = ObtenerVolumen();


        }

    }

    public class TrianguloRectangulo
    {
        private double catetoA { get; set; }
        private double anguloOpuestoA { get; set; }

        public TrianguloRectangulo(double catetoA, double anguloOpuestoA)
        {
            this.catetoA = Math.Abs(catetoA);
            this.anguloOpuestoA = Math.Abs(anguloOpuestoA);
        }

        public double ObtenerCatetoA()
        {
            double CatetoA = catetoA;
            CatetoA = Math.Round(catetoA, 3);
            return CatetoA;
        }
        public double ObtenerCatetoB()
        {
            double catetoB = 0;
            double radianes = anguloOpuestoA * (Math.PI / 180);
            catetoB = catetoA / (Math.Tan(radianes));
            catetoB = Math.Round(catetoB, 3);
            return catetoB;
        }
        public double ObtenerHipotenusa()
        {
            double hipotenusa = 0;
            double radianes = anguloOpuestoA * (Math.PI / 180);
            hipotenusa = catetoA / (Math.Sin(radianes));
            hipotenusa = Math.Round(hipotenusa,3);
            return hipotenusa;
        }
        public double ObtenerAnguloOpuestoA()
        {
            double AnguloOpuestoA = anguloOpuestoA;
            AnguloOpuestoA = Math.Round(AnguloOpuestoA, 3);
            return AnguloOpuestoA;
        }
        public double ObtenerAnguloOpuestoB()
        {
            double anguloOpuestoB = 0;
            anguloOpuestoB = 180 - (anguloOpuestoA + 90);
            anguloOpuestoB= Math.Round(anguloOpuestoB, 3);
            return anguloOpuestoB;
        }
        public double ObtenerArea()
        {
            double area = 0;
            area = (catetoA * ObtenerCatetoB())/2;
            area = Math.Round(area,3);
            return area;
        }
        



    } 
}
    