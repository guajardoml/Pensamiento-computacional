using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_MLGJ_2002423
{
    class Program
    {
        static void Main(string[] args)
        {
            //int resultado = 0;
            //int numeroveces = 1;
            //string texto = "";

            //Console.WriteLine("Ingrese un numero entero de 1 a 100: ");
            //int numero = Int32.Parse(Console.ReadLine());

            //if (numero > 0)
            //{
            //    do
            //    {
            //        resultado = resultado + numeroveces;
            //        texto = texto + numeroveces + "+";
            //        Console.WriteLine(texto);
            //        numeroveces++;


            //    } while (numeroveces <= numero);

            //    Console.WriteLine();
            //    Console.WriteLine("El resultado es: " + resultado);
            //}
            //else
            //{
            //    Console.WriteLine("El numero ingresado no cumple con las condiciones");
            //    numero = Int32.Parse(Console.ReadLine());
            //}


            //int multiplicacion = 0;
            //Console.WriteLine("Ingrese un numero para ver su tabla de multiplicar: ");
            //int numeromulti = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("La tabla del numero 1 es: ");
            //for (int i = 1; i<=10; i++)
            //{
            //    multiplicacion = i * numeromulti;
            //    Console.Write("{0}|", multiplicacion);

            //}


            int multiplicacion = 0;
           
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La tabla del numero {0} es: ",i );
                Console.WriteLine();


                for (int j = 1; j <= 10; j++)
                {
                    multiplicacion = i * j;
                    Console.Write("{0}|", multiplicacion);
                }

                

            }

            Console.ReadKey();
        }
    }
}