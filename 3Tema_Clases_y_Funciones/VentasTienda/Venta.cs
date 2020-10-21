using System;
using System.Collections.Generic;
using System.Text;

namespace VentasTiendaSemanales
{
    class Venta
    {
        private String dia;
        private Double ganancia;

        //Cosntructores
        public Venta() { }

        public Venta(String dia, Double ganancia)
        {
            this.dia = dia;
            this.ganancia = ganancia;
        }

        //SETTER Y GETTER
        public String DIA
        {
            get { return this.dia; }
            set { this.dia = value;  }
        }


        public Double GANANCIA
        {
            get { return this.ganancia; }
            set { this.ganancia = value; }
        }

        //To String
        public String toString()
        {
            return this.dia + " " + this.ganancia;
        }

    }
}
