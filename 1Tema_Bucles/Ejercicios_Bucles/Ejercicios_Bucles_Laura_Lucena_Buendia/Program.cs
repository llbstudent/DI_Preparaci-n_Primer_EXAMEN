using System;

namespace Ejercicios_Bucles_Laura_Lucena_Buendia
{
    /// <summary>
    /// Primer programa realizado para el repaso de bucles. (Sólo con lo explicado en clase/No Arrays)
    /// Trabajo de clase - Profesor Álvaro López Jurado
    /// 
    /// Deberá realizar lo siguiente:
    /// 1. Factorial
    /// 2. Clave
    /// 3. Números primos
    /// 4. Mayusculas descendentes
    /// 5. Salir
    /// 
    /// @author - Alumno. Laura Lucena Buendia
    /// </summary>
    class Program
    {
        //Main
        static void Main(string[] args)
        {
            Boolean menuPrincipal = true;

            //Menu principal
            do
            {
                Console.WriteLine("\n**************  EJERCICIOS DE BUCLES   ************" +
                "\n1.Factorial" +
                "\n2.Clave" +
                "\n3.Numeros primos" +
                "\n4.Mayúsculas descendentes" +
                "\n5.Salir" +
                "\n****************************************************");

                //Condicion selección menú (Para que sólo pueda insertar números)
                Boolean es_numero = false;
                int numeroTest = 0;
                int numeroOpcionMenu = 0;
                do
                {
                    Console.Write("\nInserte opción: ");
                    String input = Console.ReadLine();

                    if (int.TryParse(input, out numeroTest))
                    {
                        numeroOpcionMenu = numeroTest;
                        es_numero = true;
                    }

                } while (!es_numero);

                //SWITCH (Dependiendo de lo que hayamos introducido hará un ejercicio o saldrá de aplicación)
                switch (numeroOpcionMenu)
                {
                    case 1:
                        Console.WriteLine("\nEj1. Factorial");
                        Console.Write("Escribe un número dado para calcular el factorial: ");
                        int numFactorial = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("El factorial del número '" + numFactorial + "' es: " + calculoFactorial(numFactorial));
                        pulsarParaSeguir();
                        break;

                    case 2:
                        Console.WriteLine("\nEj2. Clave");
                        clave_de_Usuario();
                        pulsarParaSeguir();
                        // comentario personal: Realizarlo la próxima vez con '.remove()'
                        break;

                    case 3:
                        Console.WriteLine("\nEj3. Números Primos");
                        Console.Write("Inserte cuantos números primos desea obtener (irán en orden): ");
                        int numPrimos = Convert.ToInt32(Console.ReadLine());
                        encontrarNumerosPrimos(numPrimos);
                        pulsarParaSeguir();
                        break;


                    case 4:
                        Console.WriteLine("\nEj4. Mayúsculas descendentes");
                        mayusculasDescendentes();
                        pulsarParaSeguir();
                        break;


                    case 5:
                        menuPrincipal = false;
                        Console.WriteLine("\nHasta pronto");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("\nOpción no contemplada en el menú");
                        pulsarParaSeguir();
                        break;
                }

            } while (menuPrincipal);//Fin Menu principal
        }


        //-----------------------
        // MÉTODOS DEL PROGRAMA
        //-----------------------


        /// <summary>
        /// Método que nos calcula el factorial de un número entero
        /// En nuestra valiable local resultado se nos almacenará el valor del número que le hemos pasado por parámetros
        /// Nuestro bucle for ira con su variable inicializada 'i' multiplicandose con la variable 'resultado'
        /// hasta que no sea menor que el valor de  'num'
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns>
        /// Nos devolverá el resultado de dicha multiplicación
        /// </returns>
        public static int calculoFactorial(int num)
        {
            int resultado = num;
            for (int i = 1; i < num; i++)
            {
                resultado *= i;
            }
            return resultado;
        }


        //Clave de usuario
        /// <summary>
        /// CLAVE DE USUARIO
        /// El método nos leerá uno por uno los caracteres que vayamos introduciendo y se irán sumando a nuestra
        /// variable de tipo 'String' - 'pass'
        /// En el momento que insertemos el símbolo '*'
        /// se nos mostrarán todos los caracteres que hemos introducido como clave
        /// </summary>
        private static void clave_de_Usuario()
        {
            Boolean presionarAsterisco = false;
            char tecla;
            String pass = "";

            Console.WriteLine("Inserte una clave. El símbolo '*' indicará el final de esta");
            do
            {
                //Leemos sólo un caracter
                tecla = Console.ReadKey(false).KeyChar;

                if (tecla == '*')
                {
                    presionarAsterisco = true;
                }
                else
                    pass += tecla;

            } while (!presionarAsterisco);
            Console.WriteLine("La contraseña es '" + pass + "'");

            /*
             //Opción incorrecta
            String clave = "";
            String claveGuardada = "";

            do
            {
                Console.Write("¿Qué clave deseas? ");
                clave = Console.ReadLine();

                if (clave != "*")
                    claveGuardada = clave;
                else
                    Console.WriteLine("La clave es '" + claveGuardada + "'");

            } while (clave != "*");             
             */        
        }


        /// <summary>
        /// MOSTRAR LOS 'X' PRIMEROS NÚMEROS PRIMOS
        /// El método recibe un número entero, introducido previamente por teclado
        /// en el que a través de varios bucles 'for' y una serie de condiciones
        /// </summary>
        /// <param name="numPrimos"></param>
        private static void encontrarNumerosPrimos(int numPrimos)
        {
            int contadorNumPrimos = 0;

            for (int num = 2; contadorNumPrimos < numPrimos; num++)
            {
                //Primero contamos el '2'
                if(num == 2)
                {
                    contadorNumPrimos++;
                    Console.WriteLine(contadorNumPrimos + " => " + num);

                }
                //Empezamos a recorrer los 'x' números restantes
                else
                {
                    Boolean esPrimo = true;
                    for (int divisor = 2; divisor <= num/2; divisor++)
                    {
                        if (num % divisor == 0)
                            esPrimo = false;
                    }

                    if (esPrimo)
                    {
                        contadorNumPrimos++;
                        Console.WriteLine(contadorNumPrimos + " => " + num);
                    }
                }
            }
        }


       
        /// <summary>
        /// ABECEDARIO INVERSO
        /// Método en el que usamos un 'casteo' para poder sacar las letras del abecedario en mayúsculas utilizando el código ascii
        /// Deberán estar ordenadas a la inversa (Z-A)
        /// Debemos conocer previamente los números a los que corresponden y hacer una cuenta atrás
        /// </summary>
        private static void mayusculasDescendentes()
        {
            for (int letra = 90; letra >= 65; letra--)
            {
                Console.WriteLine((char)(letra));
            }
        }


        // Función para resetear el menu
       /// <summary>
       /// FUNCIÓN PARA RESETEAR EL MENÚ
       /// Tal y como se nos muestra en el ejercicio
       /// Cada vez que se haya terminado de ejecutar un opción el programa dejará 3 líneas en blanco con un mensaje.
       /// En el momento que se pulse 'intro' volveremos al menú principal
       /// </summary>
       private static void pulsarParaSeguir()
        {
            Console.WriteLine("\n\n\n ----- Pulse para seguir -----");
            Console.ReadKey();
        }
    }
}
