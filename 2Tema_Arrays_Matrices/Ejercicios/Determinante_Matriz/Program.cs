using System;

namespace Determinante_Matriz
{
    class Program
    {
        public static void rellenar_subMatriz(Matriz submatriz, Matriz matriz)
        {
            if (submatriz.ID != null || submatriz.ID.Length >= 0)
            {
                if(submatriz.ID == "subMatriz1")
                {
                    try
                    {
                        submatriz.MATRIZ[0, 0] = matriz.MATRIZ[1, 1];
                        submatriz.MATRIZ[0, 1] = matriz.MATRIZ[1, 2];
                        submatriz.MATRIZ[0, 2] = matriz.MATRIZ[1, 3];
                        submatriz.MATRIZ[1, 0] = matriz.MATRIZ[2, 1];
                        submatriz.MATRIZ[1, 1] = matriz.MATRIZ[2, 2];
                        submatriz.MATRIZ[1, 2] = matriz.MATRIZ[2, 3];
                        submatriz.MATRIZ[2, 0] = matriz.MATRIZ[3, 1];
                        submatriz.MATRIZ[2, 1] = matriz.MATRIZ[3, 2];
                        submatriz.MATRIZ[2, 2] = matriz.MATRIZ[3, 3];
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("Se ha accedido a un elemento fuera de los límites/no existe.");
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("ERROR INESPERADO");
                    }


                }
                else if(submatriz.ID == "subMatriz2")
                {
                    try
                    {
                        submatriz.MATRIZ[0, 0] = matriz.MATRIZ[1, 0];
                        submatriz.MATRIZ[0, 1] = matriz.MATRIZ[1, 2];
                        submatriz.MATRIZ[0, 2] = matriz.MATRIZ[1, 3];
                        submatriz.MATRIZ[1, 0] = matriz.MATRIZ[2, 0];
                        submatriz.MATRIZ[1, 1] = matriz.MATRIZ[2, 2];
                        submatriz.MATRIZ[1, 2] = matriz.MATRIZ[2, 3];
                        submatriz.MATRIZ[2, 0] = matriz.MATRIZ[3, 0];
                        submatriz.MATRIZ[2, 1] = matriz.MATRIZ[3, 2];
                        submatriz.MATRIZ[2, 2] = matriz.MATRIZ[3, 3];
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("Se ha accedido a un elemento fuera de los límites/no existe.");
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("ERROR INESPERADO");
                    }
                }
                else if (submatriz.ID == "subMatriz3")
                {
                    try
                    {
                        submatriz.MATRIZ[0, 0] = matriz.MATRIZ[1, 0];
                        submatriz.MATRIZ[0, 1] = matriz.MATRIZ[1, 1];
                        submatriz.MATRIZ[0, 2] = matriz.MATRIZ[1, 3];
                        submatriz.MATRIZ[1, 0] = matriz.MATRIZ[2, 0];
                        submatriz.MATRIZ[1, 1] = matriz.MATRIZ[2, 1];
                        submatriz.MATRIZ[1, 2] = matriz.MATRIZ[2, 3];
                        submatriz.MATRIZ[2, 0] = matriz.MATRIZ[3, 0];
                        submatriz.MATRIZ[2, 1] = matriz.MATRIZ[3, 1];
                        submatriz.MATRIZ[2, 2] = matriz.MATRIZ[3, 3];
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("Se ha accedido a un elemento fuera de los límites/no existe.");
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("ERROR INESPERADO");
                    }
                }
                else if (submatriz.ID == "subMatriz4")
                {
                    try
                    {
                        submatriz.MATRIZ[0, 0] = matriz.MATRIZ[1, 0];
                        submatriz.MATRIZ[0, 1] = matriz.MATRIZ[1, 1];
                        submatriz.MATRIZ[0, 2] = matriz.MATRIZ[1, 2];
                        submatriz.MATRIZ[1, 0] = matriz.MATRIZ[2, 0];
                        submatriz.MATRIZ[1, 1] = matriz.MATRIZ[2, 1];
                        submatriz.MATRIZ[1, 2] = matriz.MATRIZ[2, 2];
                        submatriz.MATRIZ[2, 0] = matriz.MATRIZ[3, 0];
                        submatriz.MATRIZ[2, 1] = matriz.MATRIZ[3, 1];
                        submatriz.MATRIZ[2, 2] = matriz.MATRIZ[3, 2];
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("Se ha accedido a un elemento fuera de los límites/no existe.");
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("ERROR INESPERADO");
                    }

                }
                else
                {
                    throw new MiExcepcion("El ID de la matriz no corresponde con algunos de los establecidos");
                }
            }
            else
            {
                throw new MiExcepcion("Esta matriz no contiene nigún ID");
            }
        }


        public static int calcular_determinante_SAURRUS(Matriz matriz)
        {
            int parteA = (matriz.MATRIZ[0, 0] * matriz.MATRIZ[1, 1] * matriz.MATRIZ[2, 2])
                + (matriz.MATRIZ[0, 1] * matriz.MATRIZ[1, 2] * matriz.MATRIZ[2, 0])
                + (matriz.MATRIZ[1, 0] * matriz.MATRIZ[2, 1] * matriz.MATRIZ[0, 2]);

            int parteB = (matriz.MATRIZ[2, 0] * matriz.MATRIZ[1, 1] * matriz.MATRIZ[0, 2])
                +(matriz.MATRIZ[1, 0] * matriz.MATRIZ[0, 1] * matriz.MATRIZ[2, 2])
                +(matriz.MATRIZ[2, 1] * matriz.MATRIZ[1, 2] * matriz.MATRIZ[0, 0]);

            return parteA - parteB;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("MATRIZ:");
            Matriz matriz = new Matriz();

            matriz.rellenar_matriz();
            matriz.imprimirMatriz();

            //CREAMOS SUBMATRICES Y LAS RELLENAMOS PARA SEGUIR LA FÓRMULA DE LAPLACE
            Matriz subMatriz1 = new Matriz(3, "subMatriz1");
            Matriz subMatriz2 = new Matriz(3, "subMatriz2");
            Matriz subMatriz3 = new Matriz(3, "subMatriz3");
            Matriz subMatriz4 = new Matriz(3, "subMatriz4");

            rellenar_subMatriz(subMatriz1, matriz);
            rellenar_subMatriz(subMatriz2, matriz);
            rellenar_subMatriz(subMatriz3, matriz);
            rellenar_subMatriz(subMatriz4, matriz);

            //CALCULAMOS LOS DETERMINANTES INDIVIDUALMENTE POR LA REGLA SE SAURUS
            int det1 = calcular_determinante_SAURRUS(subMatriz1);
            int det2 = calcular_determinante_SAURRUS(subMatriz2);
            int det3 = calcular_determinante_SAURRUS(subMatriz3);
            int det4 = calcular_determinante_SAURRUS(subMatriz4);

            int result_determ = (matriz.MATRIZ[0, 0] * det1) - (matriz.MATRIZ[0, 1] * det2)
                + (matriz.MATRIZ[0, 2] * det3) - (matriz.MATRIZ[0, 3] * det4);

            Console.WriteLine("\nDETERMINANTE MATRIZ: " + result_determ);
                                                  
            
              /*
             //PRINTS
             //ECHAMOS UN VISTAZO A LAS SUBMATRICES POR PANTALLA, PARA COMPROBAR QUE NO HA HABIDO ERRORES AL RELLENARLAS
            Console.WriteLine("------------------------------");
            Console.WriteLine("SUB-MATRIZ(A):");
            subMatriz1.imprimirMatriz();
            Console.WriteLine();

            Console.WriteLine("SUB-MATRIZ(B):");
            subMatriz2.imprimirMatriz();
            Console.WriteLine();

            Console.WriteLine("SUB-MATRIZ(C):");
            subMatriz3.imprimirMatriz();
            Console.WriteLine();

            Console.WriteLine("SUB-MATRIZ(D):");
            subMatriz4.imprimirMatriz();
            Console.WriteLine();

            Console.WriteLine("------------------------------");

            //PARA LOS DETERMINANTES INDIVIDUALES:
            Console.WriteLine("det1: " + det1);
            Console.WriteLine("det2: " + det2);
            Console.WriteLine("det3: " + det3);
            Console.WriteLine("det4: " + det4);
            */             
        }
    }
}
