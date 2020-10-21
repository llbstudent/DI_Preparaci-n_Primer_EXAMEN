using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Matriz
    {
        private int filas;
        private int columnas;
        private int[,] matriz;

        //CONSTRUCTORES
        public Matriz()
        {

        }

        public Matriz(int filas, int colum)
        {
            this.filas = filas;
            this.columnas = colum;

            matriz = new int[this.filas, this.columnas];
        }

        //SETTER Y GETTER

        public int FILAS{
            get{return this.filas;}
            set{this.filas = value;}
        }

        public int COLUMNAS{
            get{ return this.columnas;}
            set{ this.columnas = value;}
        }

        public int[,] MATRIZ{
            get{ return this.matriz;}
            set{ this.matriz = value;}
        }

    }
}
