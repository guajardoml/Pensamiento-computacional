﻿class Program
{
    static void Main(string[] args)
    {

        //Estudiante estudiante_1 = new Estudiante("Mia", 17,"zona 16");

        //Console.WriteLine("nombre: "+ estudiante_1.nombre);
        //Console.WriteLine("Edad: " + estudiante_1.edad);
        //Console.ReadKey();

        Automovil automovil_1 = new Automovil();
        Console.WriteLine("Modelo:" + automovil_1.modelo);
        Console.WriteLine("Precio:" + automovil_1.precio);
        Console.WriteLine("Marca:" + automovil_1.marca);
        Console.WriteLine("Disponible:" + automovil_1.disponible);
        Console.WriteLine("Tipo de cambio del dolar:" + automovil_1.tipoCambioDolar);
        Console.WriteLine("Descuento aplicado:" + automovil_1.descuentoAplicado);

        Console.ReadKey();


    }
}
//public class Estudiante
//{
//    // atributos
//    public string nombre { get; set; }

//    public int edad { get; set; }

//    private string direccion { get; set; }

//    // constructor
//    public Estudiante(string nombre, int edad, string direccion)
//    {
//        this.nombre = nombre;
//        this.edad = edad;
//        this.direccion = direccion;
//    }



//}
public class Automovil
{
    // atributos
    public int modelo { get; set; }

    public double precio { get; set; }

    public string marca { get; set; }
    public bool disponible { get; set; }
    public double tipoCambioDolar { get; set; }

    public double descuentoAplicado { get; set; }


    // constructor
    public Automovil()
    {
        this.modelo = 2019;
        this.precio = 10000.00;
        this.marca = "";
        this.disponible = false;
        this.tipoCambioDolar = 7.50;
        this.descuentoAplicado = 0.00;
    }



}