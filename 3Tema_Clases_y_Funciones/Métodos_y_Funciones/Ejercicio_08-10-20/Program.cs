using System;

/*
 * Ejercicios para practicar el uso de las funciones/métodos
 * 
 * Estos ejercicios será realizados todos en el mismo programa, estarán dentro de un bucle 'while', por comodidad.
 * Seleccione mediante un entero el ejercico que desea realizar y se ejecutará el condicional 'switch' dentro del bucle
 * 
 * Porfesor: Álvaro López Jurado
 * Autor/Alumno: Laura Lucena Buendía
 */
namespace Ejercicio_08_10_20
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\n*********************************************************************" +
                "\nTANDA DE EJERCICIOS (08/10): Ejercicio de clases. Funciones" +
                "\n*********************************************************************");

            Boolean menuActivado = true; //variable que nos ayudará con el control del menú

            //Bucle que se ejecutará hasta que no pulsemos la opción correspondiente (En este caso el núm '4')
            do
            {
                Console.WriteLine("\n\n[1]- Primer ejercicio: Intercambiar números." +
                    "\n[2]- Segundo ejercicio: Simulación del lanzamiento de un dado '50000' veces." +
                    "\n[3]- Tercer ejercicio: Contador de palabras" +
                    "\n[4]- SALIR");

                Console.Write("\nSeleccione (mediante un número entero): ");
                int seleccionMenu = Convert.ToInt32(Console.ReadLine());

                //Dependiendo de lo que seleccionemos iremos al ejercicio correspondiente
                switch (seleccionMenu)
                {
                    //Ejercicio Intercambiar número
                    case 1:
                        int num1, num2;

                        Console.Write("Inserte el núm 1: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Inserte el núm 2: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("RESULTADO:");
                        Console.WriteLine("El primer número es \'" + num1 + "\', y el segundo número es \'" + num2 + "\'");
                        intercambiarNumeros(ref num1, ref num2);
                        Console.WriteLine("Intercambio. El primer número es \'" + num1 + "\', y el segundo número es \'" + num2 + "\'");
                        break;

                    //Ejercicio 50000 tiradas de dado
                    case 2:
                        int[] resultados = { 0, 0, 0, 0, 0, 0 };

                        contadorNumeroTirosDados(resultados);
                        //verNumeroTiradas(resultados);
                        Console.Write("Inserte un número entre el \'1\' y el \'6\', para saber cuantas veces ha salido = ");
                        int numRes = Convert.ToInt32(Console.ReadLine());
                        int numapariciones = conocerNumApariciones(numRes, resultados);
                        Double porcentajeResultado = conocerPorcentaje(numapariciones);
                        Console.WriteLine("RESULTADO:");
                        Console.WriteLine("El número \'" + numRes + "\' ha aparecido \'" + numapariciones
                            + "\' veces, es decir el \'" + porcentajeResultado + "%\'");
                        break;

                    // Ejercicio devolver el número de palabras de una frase
                    case 3:
                        Console.Write("Inserte una frase: ");
                        String frase = Console.ReadLine();
                        //Le quitamos también los espacios
                        String[] palabrasFrase = frase.Trim().Split(' ');
                        Console.WriteLine("RESULTADO:");
                        imprimirFrase(palabrasFrase, frase);
                        break;

                    //Para Salir del programa
                    case 4:
                        Console.WriteLine("Hasta pronto");
                        menuActivado = false;
                        break;
                }                

            } while (menuActivado);
            Console.ReadLine();
        }

        //--------------------------------------------------------------
        // MÉTODOS / FUNCIONES
        //--------------------------------------------------------------

        //--------------------------------
        // Métodos Ejercicio 1
        //--------------------------------
        public static void intercambiarNumeros(ref int num1, ref int num2)
        {
            int numAux = num1;
            num1 = num2;
            num2 = numAux;
        }


        //--------------------------------
        // Métodos Ejercicio 2
        //--------------------------------

        //Nos rellenará nuestro array con los resultados de nuestras tiradas
        private static void contadorNumeroTirosDados(int[] resultados)
        {
            Random generador = new Random();
            for (int i = 0; i < 50000; i++)
            {
                int aleatorio = generador.Next(1, 7);
                switch (aleatorio)
                {
                    case 1:
                        resultados[0] += 1;
                        break;

                    case 2:
                        resultados[1] += 1;
                        break;

                    case 3:
                        resultados[2] += 1;
                        break;

                    case 4:
                        resultados[3] += 1;
                        break;

                    case 5:
                        resultados[4] += 1;
                        break;

                    case 6:
                        resultados[5] += 1;
                        break;
                }
            }
        }

        //Nos devuelve el número de apariciones, de un un determinado número
        private static int conocerNumApariciones(int numRes, int[] resultados)
        {
            int result = 0;
            for (int i = 0; i < resultados.Length; i++)
            {
                if (i == (numRes - 1))
                    result = resultados[i];
            }
            return result;
        }


        //nos permite conocer el porcentaje de tiradas de ese número
        private static Double conocerPorcentaje(int num)
        {
            return (num * 100) / 50000;
        }


        //Método de ayuda, no lo pide el ejercicio, pero lo use para ver reflejado los reultados
        // Y así poder comprobar que se estaba realizando correctamente
        // Nos imprime el resultado de veces que ha salido cada número
        private static void verNumeroTiradas(int[] resultados)
        {
            for (int i = 0; i < resultados.Length; i++)
            {
                Console.WriteLine("Resultado núm\'" + (i + 1) + "\' = " + resultados[i]);
            }
        }


        //--------------------------------
        // Métodos Ejercicio 3
        //--------------------------------
        

        /// <summary>
        /// Método que nos imprime la frase y el número de palabras. Ejercicio-3
        /// </summary>
        /// <param name="palabrasFrase"></param>
        private static void imprimirFrase(string[] palabrasFrase, String frase)
        {
            Console.WriteLine("Frase: " + frase);

            for (int i=0; i < palabrasFrase.Length; i++)
            {
                Console.Write("\nPalabra " +(i+1)+ ": " + palabrasFrase[i]);
            }
        }
    }
}
