using System;

namespace Ej2_MatrizCuadrada
{
    class ProgramPrincipal
    {
        static void Main(string[] args)
        {
            int tam;
            int opcionRellenarMatriz;

            Console.WriteLine("-----------------\nBIENVENIDO\n-----------------");
            Console.Write("Inserte el Tamaño de su matriz cuadrada: ");
            tam = Convert.ToInt32(Console.ReadLine());
            MatrizCuadrada m1 = new MatrizCuadrada(tam);

            //Opción de rellenar la matriz
            do
            {
                Console.WriteLine("Seleccione cómo desea rellenar la matriz: ");
                Console.WriteLine("1- Números enteros aleatorios (1-100)");
                Console.WriteLine("2- Números insertados por teclado (pueden ser decimales y enteros)");
                opcionRellenarMatriz = Convert.ToInt32(Console.ReadLine());

                if (opcionRellenarMatriz == 1)
                {
                    m1.rellenarMatrizAleatoriamente();
                    

                }
                else if (opcionRellenarMatriz == 2)
                {
                    m1.rellenarMatrizTeclado();
                }
                else
                {
                    Console.WriteLine("Por favor seleccione correctamente una de las dos opciones");
                }
            } while (opcionRellenarMatriz != 1 && opcionRellenarMatriz != 2);

            //SUMATORIOS
            m1.imprimirMatriz();

            Console.WriteLine("\nSUMA DIAGONAL PRINCIPAL: " + m1.sumaDiagonalPrincipal());
            Console.WriteLine("\nSUMA DIAGONAL SECUNDARIA: " + m1.sumaDiagonalSecundaria());
            Console.WriteLine("\nSUMA ELEMETOS TRIANGULAR SUPERIOR: " + m1.sumaTrianguloSUP());
            Console.WriteLine("\nSUMA ELEMETOS TRIANGULAR INFERIOR: " + m1.sumaTrianguloINF());




        }
    }
}
