using System;

namespace EjercicioMatriz_5X3
{
    class Program
    {
        //Se rellena la matriz con números aleatorios
        public static void rellenarMatriz(int[,] ma)
        {
            Random rdn = new Random();

            for (int i = 0; i < ma.GetLength(0); i++){
                for(int j = 0; j < ma.GetLength(1); j++)
                {
                    ma[i, j] = rdn.Next(0, 50);
                }
            }
        }

        //Imprime matriz
        public static void imprimirMatriz(int[,] ma)
        {
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    if(j == (ma.GetLength(1) - 1))
                    {
                        Console.Write(ma[i, j]);
                    }
                    else
                    {
                        Console.Write(ma[i, j] + "\t");
                    }
                }
                Console.WriteLine("]");
            }
        }

        //Rellenar la segunda matriz
        public static void rellena_matriz2(int[,] m1, int[,] m2)
        {
            for (int i = 0; i < m1.GetLength(0); i++){
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    if (j%2 == 0)
                    {
                        m2[i, j] = (int)Math.Pow(m1[i, j], 3);
                    }
                    else
                    {
                        m2[i, j] = (int)Math.Pow(m1[i, j], 2);
                    }
                }
            }
        }



        static void Main(string[] args)
        {
            int[,] m1 = new int[5,3];
            int[,] m2 = new int[5,3];

            rellenarMatriz(m1);

            Console.WriteLine("MATRIZ RELLENA:");
            imprimirMatriz(m1);

            Console.WriteLine("\nMATRIZ CON SUS ELEMENTOS ELEVADOS AL CUADRADO Y AL CUBO:");
            rellena_matriz2(m1, m2);
            imprimirMatriz(m2);
        }
    }
}
