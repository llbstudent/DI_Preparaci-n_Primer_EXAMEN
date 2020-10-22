using System;

namespace Ref_Out
{
    /// <summary>
    /// Hay dos formas posibles de pasar un tipo de valor por referencia: ref y out . 
    /// La diferencia es que al pasarlo con ref el valor debe inicializarse, pero no al pasarlo por out . 
    /// Usando out asegura que la variable tiene un valor después de la llamada al método
    /// 
    /// Por lo tanto, out significa salir, mientras que ref es para entrar y salir.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Out y Ref nos servirán básicamente para devolvernos ese parametro y obtener esos cambios
            // Ejemplos:
            int num1 = 5;
            int num2 = 5;
            int resultado = 0;

            //Probar métodos
            //suma(num1, num2, resultado);
            //sumaRef(num1, num2, ref resultado);
            sumaOut(num1, num2, out resultado);


            Console.WriteLine("El resultado de la suma de \'{0}\' y \'{1}\' es: \'{2}\'", num1, num2, resultado);
            Console.ReadLine();
        }


        //Suma normal
        private static void suma(int num1, int num2, int resultado)
        {
            resultado = num1 + num2;
        }
        
        //Suma con Ref
        private static void sumaRef(int num1, int num2, ref int resultado)
        {
            resultado = num1 + num2;
        }


        //Suma con Out
        private static void sumaOut(int num1, int num2, out int resultado)
        {
            resultado = num1 + num2;
        }
    }
}
