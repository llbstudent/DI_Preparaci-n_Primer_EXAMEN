using System;
using System.Collections.Generic;
using System.Text;

namespace Determinante_Matriz
{
    public class Matriz
    {
        private readonly int tam = 4;
        private int[,] matriz;
        private String ID_matriz;

        //Constructores
        public Matriz()
        {
            this.matriz = new int[this.tam, this.tam];
        }

        public Matriz(int custom_tam)
        {
            this.matriz = new int[custom_tam, custom_tam];
        }

        public Matriz(int custom_tam, String ID)
        {
            this.ID_matriz = ID;
            this.matriz = new int[custom_tam, custom_tam];
        }

        //SETTER Y GETTER 
        public int TAM
        {
            get { return this.tam; }
        }

        public int[,] MATRIZ
        {
            get { return this.matriz; }
            set { this.matriz = value; }
        }

        public String ID
        {
            get { return this.ID_matriz; }
            set { this.ID_matriz = value; }
        }

        //Metodos
        public void rellenar_matriz()
        {
            Random rdn = new Random();

            for (int i = 0; i < MATRIZ.GetLength(0); i++)
            {
                for (int j = 0; j < MATRIZ.GetLength(1); j++)
                {
                    MATRIZ[i, j] = rdn.Next(0, 50);
                }
            }
        }

        public void imprimirMatriz()
        {
            for (int i = 0; i < MATRIZ.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < MATRIZ.GetLength(1); j++)
                {
                    if (j == (MATRIZ.GetLength(1) - 1))
                    {
                        Console.Write(MATRIZ[i, j]);
                    }
                    else
                    {
                        Console.Write(MATRIZ[i, j] + "\t");
                    }
                }
                Console.WriteLine("]");
            }
        }
    }
}
