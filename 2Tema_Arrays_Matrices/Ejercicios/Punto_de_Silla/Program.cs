using System;

namespace ConsoleApp1
{
    class Program
    {
        
        //Rellenamos la matriz con números enteros
        public static void rellena_matriz(int[,] matriz){
            int ejem = 0;
            try
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Boolean is_numeric = false;

                        do {
                            Console.Write("Posición[" + i + "][" + j + "]: ");
                            String input = Console.ReadLine();

                            if (int.TryParse(input, out ejem))
                            {
                                matriz[i, j] = ejem;
                                is_numeric = true;
                            }                
                            
                        } while (!is_numeric);
                        
                    }
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Referencia a objeto nulo  ");
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.ToString());
            }
        }

        //Imprime matriz
        public static void imprimirMatriz(int[,] ma)
        {
            try
            {
                for (int i = 0; i < ma.GetLength(0); i++)
                {
                    Console.Write("[");
                    for (int j = 0; j < ma.GetLength(1); j++)
                    {
                        if (j == (ma.GetLength(1) - 1))
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
            catch (NullReferenceException)
            {
                Console.WriteLine("Referencia a objeto nulo  ");
            }

        }


        public static void buscar_punto_de_silla(int[,] ma)
        {
            try
            {
                for (int i = 0; i < ma.GetLength(0); i++){
                    for (int j = 0; j < ma.GetLength(1); j++)
                    {
                        int item = ma[i, j];
                        Boolean isRowMin = true;
                        Boolean isColumnMax = true;

                        //Comprobamos las filas
                        for (int k = 0; k < ma.GetLength(1); k++)
                        {
                            if (ma[i, k] < item)
                            {
                                isRowMin = false;
                            }
                        }

                        //Comprobamos las columnas
                        for (int k = 0; k < ma.GetLength(0); k++)
                        {
                            if (ma[k, j] > item)
                            {
                                isColumnMax = false;
                            }
                        }

                        if (isRowMin && isColumnMax)
                        {
                            Console.WriteLine("\nLa posición con punto de silla es [" + i + "," + j + "]" + " con valor: " + item);
                            return;
                        }
                    }
                }

                Console.WriteLine("\nNo existe punto de silla");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nERROR: Debe insertar sólo valores numéricos.");

            }
            catch (Exception)
            {
                Console.WriteLine("\nERROR INSEPERADO.");
            }
        }


        static void Main(string[] args)
        {
            int out_num = 0;
            int filas = 0;
            int columnas = 0;

            Boolean isNumFila = false;
            Boolean isNumColumn = false;

            //DIMENSIONES MATRIZ:
            Console.WriteLine("Introduzca los valores de las dimensiones de la matriz: ");

            try
            {
                //Para el número de filas
                do
                {
                    Console.Write("Número de filas: ");
                    String filas_input = Console.ReadLine();

                    if (int.TryParse(filas_input, out out_num))
                    {
                        filas = out_num;
                        isNumFila = true;
                    }

                } while (!isNumFila);

                //Para el número de columnas
                do
                {
                    Console.Write("Número de columnas: ");
                    String columnas_input = Console.ReadLine();

                    if (int.TryParse(columnas_input, out out_num))
                    {
                        columnas = out_num;
                        isNumColumn = true;
                    }
                } while (!isNumColumn);

                

                Matriz m1 = new Matriz(filas, columnas);

                //RELLENAMOS LA MATRIZ Y LA MOSTRAMOS POR PANTALLA (para comprobar que se ha rellenado correctamente)
                rellena_matriz(m1.MATRIZ);
                imprimirMatriz(m1.MATRIZ);

                //BUSCAMOS EL PUNTO DE SILLA
                buscar_punto_de_silla(m1.MATRIZ);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nERROR INSEPERADO." + e.ToString());
            }



        }
    }
}
