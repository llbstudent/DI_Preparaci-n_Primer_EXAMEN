using System;
using System.Linq;

/// <summary>
/// Pequeño programa donde realizamos los ejerccios de arrays y matrices.
/// De la asignatura de DESARROLLO de INTERFACES
/// PDF con las explicaciones y ejercicios adjunto
/// 
/// Professor   - Álvaro López Jurado
/// Author      - Laura Lucena Buendia
/// Year        - 2020
/// </summary>
namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean menuPrincipalActivo = true;

            do
            {
                Console.WriteLine("\n\n*************************************** EJERCICIOS ARRAY Y MATRICES *****************************************" +
                "\n\n1. Aplicación que muestre por pantalla el valor máximo \n\ty mínimo de un array de 5 elementos" +
                "\n\n2. Aplicación que pida al usuario 5 números reales \n\ty luego los muestre en el orden contrario al que se introdujeron" +
                "\n\n3. Aplicación que pida al usuario 10 números enteros \n\ty nos muestre el mayor de ellos." +
                "\n\n4. Ejercicio propuesto de la tienda" +
                "\n\n5. SALIR" +
                "\n\n***************************************************************************************************************");

                Console.Write("\nInserte opción del menú (sólo números enteros): ");
                int opcionMEnu = Convert.ToInt32(Console.ReadLine());

                switch (opcionMEnu)
                {

                    case 1:
                        Console.WriteLine("Inserte los valores del array (sólo números enteros)");
                        int[] arrEj1 = new int[5];
                        rellenarArrayEnteros(arrEj1);
                        ordenarArrayBucle(arrEj1);
                        // Array.Sort(arrEj1);  //También se puede ordenar más rápidamente usando el método 'sort()' de la clase 'Array'
                        Console.WriteLine("\nEl Array ordenado es:");
                        imprimirArrayEnteros(arrEj1);
                        break;

                    case 2:
                        Console.WriteLine("Inserte los valores del array (sólo números enteros)");
                        int[] arrEj2 = new int[5];
                        rellenarArrayEnteros(arrEj2);
                        ordenarArrayInversamente(arrEj2);
                        //Array.Reverse(arrEj2);    //También se puede ordenar a la inversa usando el método 'reverse()' de la clase 'Array'
                        Console.WriteLine("El Array ordenado a la inversa es: ");
                        imprimirArrayEnteros(arrEj2);
                        break;

                    case 3:
                        Console.WriteLine("Inserte los valores del array (sólo números enteros)");
                        int[] arrEj3 = new int[10];
                        rellenarArrayEnteros(arrEj3);

                        /*
                         * Esto podemos hacerlo de diversas maneras:
                         * 
                         * 1. Usando un método que ya tenemos 'ordenarArrayBucle()'
                         * que nos ordenará los números del array de menor a mayor y obtenerlo con la última posición de este. Código:
                         *      ordenarArrayBucle(arrEj3);
                         *      Console.WriteLine("El número mayor del array es: '" +arrEj3[arrEj3.Length - 1]+ "'");
                         *      
                         * 2. Usando el método 'Max()'. Código:
                         *      Console.WriteLine("El número mayor del array es: '" + arrEj3.Max() + "'");
                         *      
                         * 3. Crear otro método ('encontrarNumMayor()'), que nos encuentra el número mayor:
                         */
                        Console.WriteLine("\nArray:");
                        imprimirArrayEnteros(arrEj3);
                        Console.WriteLine("\nEl número mayor es '" + encontrarNumMayor(arrEj3) + "'");
                        break;

                    case 4:
                        String[] ropa = { "Camisa Caballero", "Camisa Señora", "Pantalón Caballero", "Pantalón Señora"};

                        int[,] preciosYDescuentos =
                        {
                            { 25, 18, 33, 35},
                            { 10, 5, 2, 0}
                        };

                        Double[] precioFinal = obtenerPrecioFinal(preciosYDescuentos);
                        imprimirResultadoCompleto(ropa, precioFinal);
                        break;

                    case 5:
                        menuPrincipalActivo = false;
                        Console.WriteLine("Hasta pronto");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Opción no contemplada todavía en el menú");
                        break;


                }
            } while (menuPrincipalActivo);
            
        }//Fin main


        //---------------------------------------
        // MÉTODOS DEL PROGRAMA
        //---------------------------------------


        /// <summary>
        /// Un método al que le pasamos un array de enteros (int)
        /// Y hará que lo podamos rellenar con valores introducidos por el usuario
        /// </summary>
        /// <param name="arr"></param>
        private static void rellenarArrayEnteros(int[] arr)
        {
            for(int i=0; i < arr.Length; i++)
            {
                Console.Write("Elemento [" +(i+1)+ "] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

        }


        /// <summary>
        /// Nos ordena un Array a través de 2 bucles (while y for)
        /// 
        /// WHILE -> Establece el control sobre 'arrayOrdenado' (inicializado a 'true', por si estuvierá ya ordenado).
        /// 
        /// FOR -> Es el bucle dentro del bucle principal, 'while', 
        /// simplemente nos recorre el Array, y compará el indice principal ('i') con el número que le sigue ('i+1').
        /// Si se detecta un cambio de posición (entra en la condicional 'if') 'arrayOrdenado' será false y se volverá a ejecutar el primer bucle
        /// 
        /// 
        /// Mientras la variable 'arrayOrdenado' sea 'false' seguira entrando por el primer bucle 'while'
        /// </summary>
        /// <param name="arr"></param>
        private static void ordenarArrayBucle(int[] arr)
        {
            int aux = 0;
            Boolean arrayOrdenado = false;

            while (!arrayOrdenado)
            {
                arrayOrdenado = true;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;
                        arrayOrdenado = false;
                    }
                }
            }
        }


        /// <summary>
        /// Método que nos ordena un array de forma inversa
        /// Usamos un bucle 'for' en el que se ejecutaran una serie de cambios (la mitad de la longitud del array)
        /// 
        /// La variable 'i' nos ayudará con los indices para el intercambio de posición
        /// </summary>
        /// <param name="arr"></param>
        private static void ordenarArrayInversamente(int[] arr)
        {
            for (int i=0; i < arr.Length/2; i++)
            {
                int aux = arr[i];   //Guardamos en una variable auxiliar
                arr[i] = arr[arr.Length - 1 - i];   
                arr[arr.Length - 1 - i] = aux;
            }
        }

        /// <summary>
        /// Método que nos encuentra el número mayor y nos lo retorna.
        /// Almacena en una variable el resultado mientras recorre el bucle.
        /// Si el número del 'indice' es mayor que el resultado almacenado, el resultado almacenado toma a este como nuevo valor.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int encontrarNumMayor(int[] arr)
        {
            int numMayor = 0;

            for (int i=0; i < arr.Length; i++)
            {
                if (numMayor < arr[i])
                    numMayor = arr[i];
            }
            return numMayor;
        }


        /// <summary>
        /// Método que nos devuelve en un 'array' el precio final por cada prenda
        /// 
        /// He querido que el método sea más dinámico, y que no sólo multiplique 2 filas, es decir,
        /// si le pasas una matriz con 'X'-filas las multiplicará igualmente que si tiene 2 o 30, era simplemente por añadirle algo de eficiencia.
        /// 
        /// Nos recorrerá la matriz a través de 2 bucles'for', donde se multiplicarán las columnas,
        /// añadiremos el resultado de la multiplicación en la variable 'aux'.
        /// Al principio del segundo bucle, tendremos un condicional, que es ahí donde guardaremos el valor del precio original (en 'precioReal')
        /// Al final calculamos el precio definitivo aplicando el descuento y guardamos dentro de nuestro array 'precioFinal'
        /// 
        /// </summary>
        /// <param name="preciosYDescuentos"></param>
        /// <returns></returns>
        private static double[] obtenerPrecioFinal(int[,] mat)
        {
            double[] precioFinal = new double[mat.GetLength(1)];

            for (int i=0; i <mat.GetLength(1); i++)
            {


                double aux = 1;
                int precioReal = 0;
                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    if (j == 0)
                        precioReal = mat[j, i];

                    aux *= mat[j,i];
                }
                precioFinal[i] = precioReal - (aux / 100);
            }
            return precioFinal;
        }


        //-------------
        // Métodos para imprimir Arrays por consola
        //-------------

        /// <summary>
        /// Nos muestra un array de enteros por consola, con algo de formato
        /// 
        /// Es un método para comprobar en algunos casos si hay errores, aunque algunos ejercicios no lo pidan
        /// </summary>
        /// <param name="arr"></param>
        private static void imprimirArrayEnteros(int[] arr)
        {
            Console.Write("{");
            for (int i=0; i< arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i != arr.Length - 1)
                    Console.Write(", ");
            }
            Console.Write("}");
        }


        /// <summary>
        /// Nos imprime el resultado con el formato deseado
        /// La consola no acepta el símbolo '€', así que va escrito a mano
        /// </summary>
        /// <param name="ropa"></param>
        /// <param name="precioFinal"></param>
        private static void imprimirResultadoCompleto(string[] ropa, double[] precioFinal)
        {
            Console.WriteLine("Resultado: ");
            for (int i = 0; i < ropa.Length; i++)
            {
                Console.WriteLine("· " + ropa[i] + " " + precioFinal[i] + " -Euros");
            }
        }
    }
}
