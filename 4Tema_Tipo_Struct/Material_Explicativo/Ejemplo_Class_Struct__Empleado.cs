using System;

namespace DI_Tipos_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clase/Struct Empleado
            Empleado e1 = new Empleado(1250.50, 120);
            Console.WriteLine("Primer empleado: {0}", e1);


            //Aumenta su salario / Método-interno de su propia estructura que permiter realizar los cambios
            e1.aunmentarSalario(120.30);
            Console.WriteLine("\nAumento de salario: {0}", e1);


            // Método estático que podria estar tanto dentro de struct/como de las class 'Program'
            // Este cambio no se verá reflejado por como son internamente los struct
            // Todo se alamacena en la memoria 'stack' y trabajamos con 'copias'
            aumentoComision(e1, 50.20);
            Console.WriteLine("\nAumento de comisión: {0}", e1);

            //
            Console.ReadLine();
        }


        //Método aumentar comision
        public static void aumentoComision(Empleado e, double plusComision)
        {
            e.COMISION += plusComision;
        }
    }

    

    //------------------------------
    //Clase/Struct interna Empleado
    /// <summary>
    /// Para que esta clase sea un 'struct' basta con que le cambiemos la palabra 'class' por 'struct'
    /// Eso si, los struct no podrán contener constructores vacíos 
    /// </summary>
    /// //public class Empleado
    public struct Empleado
    {
        public double salarioBase, comision;

        //Constuctores
        //public Empleado() { }

        public Empleado(double salario, double comi) {
            this.salarioBase = salario;
            this.comision = comi;
        }


        //Modif acceso
        public double SALARIOBASE
        {
            set { this.salarioBase = value; }
            get { return this.salarioBase; }
        }

        public double COMISION
        {
            get { return this.comision; }
            set { this.comision = value; }
        }

        //ToString
        public override string ToString()
        {
            return string.Format("El salario-base del empleado es: {0}" +
                "\nComisión del empleado: {1}"
                , this.salarioBase, this.comision);
        }

        //Método de aumentar salario
        public void aunmentarSalario(double incremento)
        {
            this.salarioBase += incremento;
        }

    }
}
