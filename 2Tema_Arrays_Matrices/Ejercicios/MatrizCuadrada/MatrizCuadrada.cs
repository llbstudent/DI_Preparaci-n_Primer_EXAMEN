using System;
using System.Collections.Generic;
using System.Text;

namespace Ej2_MatrizCuadrada
{
    class MatrizCuadrada
    {
        private int tamanno;
        private float[,] matriz;

        //Constructores
        public MatrizCuadrada() { }

        public MatrizCuadrada(int tamanno) {
            this.matriz = new float[tamanno, tamanno];
        }

        //SETTER & GETTER
        public int TAM
        {
            get { return this.tamanno; }
            set { this.tamanno = value; }
        }

        public float[,] MATRIZ
        {
            get { return this.matriz; }
            set { this.matriz = value; }
        }

        //Métodos
        
        //Nos rellenará la Matriz aleatoriamente, hemos declarado este método por comodidad
        //por si la matriz cuadrada tiene unas dimensiones demasiado grandes.
        public void rellenarMatrizAleatoriamente()
        {
            Random rdn = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rdn.Next(0, 100);
                }
            }
        }

        //Rellenaremos la matriz manualmente
        public void rellenarMatrizTeclado()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("\nPosición [" +i+ "," +j+ "] = ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        //Nos imprime la matriz por pantalla, para que podamos ver los resultados 
        //correctamente y ver si coinciden.
        public void imprimirMatriz()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == (matriz.GetLength(1) - 1))
                    {
                        Console.Write(matriz[i, j]);
                    }
                    else
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }
                }
                Console.WriteLine("]");
            }
        }

        //Nos sumará los elementos de la diagonal principal de la matriz
        public float sumaDiagonalPrincipal()
        {
            float res = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                res += matriz[i, i];
            }
                return res;
        }

        //Nos sumará los elementos de la diagonal secundaria de la matriz

        public float sumaDiagonalSecundaria()
        {
            float res = 0;
            int i = matriz.GetLength(0)-1;
            for (int j = 0; j < matriz.GetLength(0); j++)
            {
                res += matriz[i, j];
                i--;
            }
            return res;
        }

        //Nos sumará los elementos del triángulo superior de la matriz
        public float sumaTrianguloSUP()
        {
            float res = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = i+1; j < matriz.GetLength(1); j++)
                {
                    res += matriz[i, j];
                }
            }
                return res;
        }

        //Nos sumará los elementos del triángulo inferior de la matriz
        public float sumaTrianguloINF()
        {
            float res = 0;
            for (int i=1; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j != i; j++)
                {
                    res += matriz[i, j];
                }
            }            
            return res;
        }
    }
}
