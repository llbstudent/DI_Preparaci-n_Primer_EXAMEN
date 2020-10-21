using System;

namespace Ejercicio1_Clase_Operacion
{
    class Operacion
    {
        static void Main(string[] args)
        {
            int opcion;
            bool menu_ejec = true;
            float valor1;
            float valor2;

            do
            {
                Console.WriteLine("\n-------------------------");
                Console.WriteLine("1-SUMAR");
                Console.WriteLine("2-RESTAR");
                Console.WriteLine("3-MULTIPLICAR");
                Console.WriteLine("4-DIVIDIR");
                Console.WriteLine("5-SALIR");
                Console.WriteLine("-------------------------");
                Console.Write("Seleccione (1-5): ");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("\nSUMA \nINSERTE LOS VALORES DEL PRIMER Y SEGUNDO NÚMERO:");
                    Console.Write("1º número: ");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2º número: ");
                    valor2 = Convert.ToInt32(Console.ReadLine());

                    Suma suma = new Suma(valor1, valor2);
                    suma.operar();
                    Console.WriteLine("Resultado: " + suma.RESULTADO);


                }
                else if(opcion == 2)
                {
                    Console.WriteLine("\nRESTA: \nINSERTE LOS VALORES DEL PRIMER Y SEGUNDO NÚMERO:");
                    Console.Write("1º número: ");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2º número: ");
                    valor2 = Convert.ToInt32(Console.ReadLine());

                    Resta resta = new Resta(valor1, valor2);
                    resta.operar();
                    Console.WriteLine("Resultado: " + resta.RESULTADO);


                }
                else if (opcion == 3)
                {
                    Console.WriteLine("\nMULTIPLICAR:\nINSERTE LOS VALORES DEL PRIMER Y SEGUNDO NÚMERO:");
                    Console.Write("1º número: ");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2º número: ");
                    valor2 = Convert.ToInt32(Console.ReadLine());

                    Multiplicacion multipl = new Multiplicacion(valor1, valor2);
                    multipl.operar();
                    Console.WriteLine("Resultado: " + multipl.RESULTADO);

                }
                else if (opcion == 4)
                {
                    Console.WriteLine("\nDIVIDIR:\nINSERTE LOS VALORES DEL PRIMER Y SEGUNDO NÚMERO:");
                    Console.Write("1º número: ");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2º número: ");
                    valor2 = Convert.ToInt32(Console.ReadLine());

                    Division div = new Division(valor1, valor2);
                    div.operar();
                    Console.WriteLine("Resultado: " + div.RESULTADO);


                }
                else if (opcion == 5)
                {
                    Console.WriteLine("\nPrograma finalizado");
                    menu_ejec = false;
                    
                }
                else
                {
                    Console.WriteLine("Seleccione una opción válida");
                }

            } while(menu_ejec);

            
        }
    }
}
