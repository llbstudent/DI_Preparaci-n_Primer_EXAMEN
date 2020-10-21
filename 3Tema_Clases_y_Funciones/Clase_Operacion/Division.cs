using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_Clase_Operacion
{
    class Division
    {
        private float valor1;
        private float valor2;
        private float resultado;

        //CONSTRUCTORES
        public Division() { }

        public Division(float valor1, float valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }


        //SETTER & GETTER
        public float VALOR1
        {
            get { return this.valor1; }
            set { this.valor1 = value; }
        }

        public float VALOR2
        {
            get { return this.valor2; }
            set { this.valor2 = value; }
        }

        public float RESULTADO
        {
            get { return this.resultado; }
            set { this.resultado = value; }
        }
        
        //MÉTODO OPERAR
        public void operar()
        {
            if(valor2 == 0)
            {
                Console.WriteLine("ERROR: No se puede dividir por '0'");
            }
            else
            {
                this.resultado = valor1 / valor2;
            }
            
        }
    }
}
