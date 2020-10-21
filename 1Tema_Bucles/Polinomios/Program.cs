using System;

/*
* Defina una clase que permita representar polinomios de segundo grado P(x) = ax2 + bx + c.
* Permita obtener las raíces de estos polinomios, es decir, los valores de x tal que P(x) = 0.
* Obtenga una aplicación consola que imprima las raíces de los siguientes polinomios:
*   a) P(x) = x2 – 4
*   b) P(x) = x – 4. 
*/

namespace Ej3_Polinomios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VAMOS A REPRESENTAR POLINOMIOS DE SEGUNDO GRADO");
            Console.WriteLine("aX2  + bX + c = 0");
            Double a;
            Double b;
            Double c;
            Double x1;
            Double x2;
            Boolean inputData = false;

            //Comprobación número 'a'
            do {
                Console.Write("\nParte a: ");
                String num = Console.ReadLine();
                inputData = Double.TryParse(num, out a);
            } while (!inputData);

            //Comprobación número 'b'
            do
            {
                Console.Write("\nParte b: ");
                String num = Console.ReadLine();
                inputData = Double.TryParse(num, out b);
            } while (!inputData);

            //Comprobación número 'c'
            do
            {
                Console.Write("\nParte c: ");
                String num = Console.ReadLine();
                inputData = Double.TryParse(num, out c);

            } while (!inputData);


            //-------------
            //Lógica
            //-------------

            // Los 3 son 0
            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("ERROR: Los 3 números no pueden ser '0'");
            }
            // 'a' y 'b' son '0'
            else if (a == 0 & b == 0 && c != 0)
            {
                Console.WriteLine("ERROR: Debe de haber algún número más que no sea '0'");
            }
            // 'a' y 'c' son '0'
            else if (a == 0 && b != 0 && c == 0)
            {
                Console.WriteLine("El valor de 'x' es '0'");
            }
            // 'b' y 'c' son '0'
            else if (a != 0 && b == 0 && c == 0)
            {
                Console.WriteLine("El valor de 'x' es '0'");
            }
            // 'c' = 0
            else if (a != 0 && b != 0 && c == 0)
            {
                x1 = -b / a;
                Console.WriteLine("El valor de 'x' es '" + x1 + "'");
            }
            // 'b' = 0
            else if (a != 0 && b == 0 && c != 0)
            {
                Double fraccion = -(c) / a;

                if(fraccion < 0)
                {
                    Console.WriteLine("No se puede realizar porque no se puede obtener la raíz cuadrada de un número negativo.");
                }
                else
                {
                    x1 = Math.Sqrt(fraccion);
                    Console.WriteLine("El valor de 'x' es '" + x1 + "'");
                    Console.WriteLine("Y también puede ser -'" + x1 + "'");
                }
                
            }
            // 'a' = 0
            else if (a == 0 && b != 0 && c != 0)
            {
                x1 = -c / b;
                Console.WriteLine("El valor de 'x' es '" + x1 + "'");
            }
            //Ninguno vale '0' -Aplicamos fórmula
            else
            {
                double raiz = Math.Pow(b, 2) - 4 * a * c;
                if(raiz < 0)
                {
                    Console.WriteLine("No se puede realizar porque no se puede obtener la raíz cuadrada de un número negativo");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(raiz)) / (2 * a);
                    x2 = (-b - Math.Sqrt(raiz)) / (2 * a);

                    Console.WriteLine("El valor de 'x' es '" + x1 + "'");
                    Console.WriteLine("Y también puede ser '" + x2 + "'");
                }                
            }
        }
    }
}
