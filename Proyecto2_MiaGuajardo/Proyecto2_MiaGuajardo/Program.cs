using System.Diagnostics.CodeAnalysis;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Bienvenido a el juego de dados");
        Console.WriteLine("¿Estas preparado?");
        Thread.Sleep(2000);
        Console.WriteLine("Iniciemos...");
        Console.WriteLine("Por favor ingresa cuantas partidas deseas jugar: ");
        int partidas = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ahora, por favor ingresa cuantos tiros de dados en total se realizaran en cada una (ingrese un numero par): ");
        int tiros = Convert.ToInt16(Console.ReadLine());
        while (tiros %2 > 0) 
        {
            Console.WriteLine("Ingrese un numero par por favor: ");
            tiros = Convert.ToInt16(Console.ReadLine());
        }

        int[] tiross = new int[tiros];

        Random rnd = new Random();
        int sumajuga = 0;
        int sumacasa = 0;
        int puntoscasa = 0;
        int puntosjuga = 0;
        int ganapuntos = 0;
        int pares = 0;
        int impares = 0;
        int pares2 = 0;
        int impares2 = 0;
        int iguales = 0;
        double tirosjuga = 0;

        int casagana = 0;
        int jugagana = 0;
        int partidass;
        int numtiros;
        double probabilidad;

        for (int p = 0; p < partidas; p++)
        {
            partidass = p+1;
            Console.WriteLine("\nPARTIDA {0}",partidass);
            for (int t = 0; t < tiros; t++)
            {
                
                int dado1 = rnd.Next(1, 7);
                int dado2 = rnd.Next(1, 7);
                if (t % 2 > 0)
                {
                    numtiros = t+1;
                    Console.WriteLine("Tiro {0}",numtiros);
                    Console.WriteLine("El jugador ha obtenido: un valor de {0} en el dado 1 y un valor de {1} en el dado 2.",dado1, dado2);
                    if (dado1 % 2 == 0)
                    {
                        pares++;
                    }
                    else
                    {
                        impares++;
                    }
                    if (dado2 % 2 == 0) 
                    {
                        pares2++;
                    }
                    else
                    {
                        impares2++;
                    }
                    if (dado1 == dado2)
                    {
                        iguales++;
                    }
                    sumajuga = dado1 + dado2;
                    if (sumajuga ==2|| sumajuga == 3|| sumajuga == 5|| sumajuga == 7|| sumajuga == 8|| sumajuga == 9)
                    {
                        puntosjuga = sumajuga;
                        ganapuntos++;
                    }
                    tiross[t] = sumajuga;
                }
                else if (t % 2 == 0)
                {
                    numtiros = t + 1;
                    Console.WriteLine("Tiro {0}", numtiros);
                    Console.WriteLine("La casa ha obtenido: un valor de {0} en el dado 1 y un valor de {1} en el dado 2.",dado1, dado2);
                    sumacasa = dado1 + dado2;
                    if (sumacasa == 2 || sumacasa == 3 || sumacasa == 5 || sumacasa == 7 || sumacasa == 8 || sumacasa == 9)
                    {
                        puntoscasa = sumacasa;
                    }
                    tiross[t] = sumacasa;
                }

                if (puntosjuga == 0 && sumajuga == 11)
                {
                    Console.WriteLine("Ups, el jugador ha obtenido una suma de 11 en su tiro y no habia ganado puntos. La casa obtiene 6 puntos.");
                    puntoscasa += 6;
                }

                if (tiross[1] == 12|| tiross[1] ==6)
                {
                    Console.WriteLine("El jugador ha obtenido una suma de 6 o 12 en su primer tiro, obtiene 12 puntos.");
                    puntosjuga += 12;
                    ganapuntos++;
                }
                if (tiross[0] == 4 || tiross[0] == 10)
                {
                    Console.WriteLine("La casa ha obtenido una suma de 4 o 10 en su primer tiro, obtiene 12 puntos.");
                    puntoscasa += 12;
                }
                
            }
            Console.WriteLine("\nLa partida ha terminado, por favor presione un boton para ver los resultados");
            Console.ReadLine();
            if (puntoscasa > puntosjuga)
            {
                Console.WriteLine("LA CASA HA GANADO LA PARTIDA");
                casagana++;
            }
            else
            {
                Console.WriteLine("EL JUGADOR HA GANADO LA PARTIDA");
                jugagana++;
            }

            tirosjuga = tiros / 2;
            double division = (double)14 / 36;
            probabilidad = Math.Pow(Convert.ToDouble(division), (double)tirosjuga);
            probabilidad = (probabilidad + (double)2 / 36)*100;
            probabilidad = Math.Round(probabilidad,3);
            
            Console.WriteLine("\n\nDATOS DEL JUGADOR: ");
            Console.WriteLine("EL jugador gano puntos en {0} tiros", ganapuntos);
            Console.WriteLine("La probabilidad del jugador de ganar puntos fue de {0}% ", probabilidad);
            Console.WriteLine("El numero de veces que salio un numero par en el dado 1 fue {0} veces y el dado 2 {1} veces.",pares,pares2);
            Console.WriteLine("El numero de veces que salio un numero impar en el dado 1 fue {0} veces y el dado 2 {1} veces.", impares, impares2);
            Console.WriteLine("Los dados salieron iguales igual en {0} ocasiones.",iguales);
            Console.WriteLine("El punteo final del jugador es de {0}",puntosjuga);
            Console.WriteLine("\nPresione enter para continuar");
            Console.ReadKey();
            Console.Clear();


            puntoscasa = 0;
            puntosjuga = 0;
            sumacasa = 0;
            sumajuga = 0;

        }

        if (jugagana>casagana)
        {
            Console.WriteLine("EL JUGADOR GANA EL JUEGO CON {0} PARTIDAS GANADAS",jugagana);
        }
        else
        {
            Console.WriteLine("LA CASA GANA EL JUEGO CON {0} PARTIDAS GANADAS",casagana);
        }
        Console.WriteLine("\nGracias por haber participado.");
        Console.ReadKey();

    }
}