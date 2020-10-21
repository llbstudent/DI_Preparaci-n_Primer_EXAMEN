using System;

namespace Ahorcado_GAME
{
    class Program
    {
        //Nos comprueba si se ha acertado una letra de las que contiene nuestra palabra
        public static Boolean comprobar_letra(char[] palabra_resuelta, char[] palabra_guiones, char letra)
        {
            Boolean letra_Acertada = false;
            for (int i = 0; i < palabra_resuelta.GetLength(0); i++)
            {
                if (palabra_resuelta[i] == letra)
                {
                    palabra_guiones[i] = letra;
                    letra_Acertada = true;
                }                
            }
            return letra_Acertada;
        }

        
        //Nos comprueba si se han acertado todas las letras
        public static Boolean comprobar_palabra(char[] palabra_guiones)
        {
            Boolean sin_guiones = true;

            for (int i = 0; i < palabra_guiones.GetLength(0); i++)
            {
                if (palabra_guiones[i] == '_')
                {
                    sin_guiones = false;
                }
            }
                return sin_guiones;
        }

        public static void imprimir_palabra(char[] palabra)
        {
            for (int i = 0; i < palabra.GetLength(0); i++)
            {
                Console.Write(palabra[i] + " ");
            }
               
        }


        static void Main(string[] args)
        {
            char letra;
            Random rdn = new Random();
            int max_errores = 8;
            Boolean letraAdivinada = false;
            Boolean palabraAdivinada = false;

            //Nos creamos un 'array' de 'String' con las palabras que tendremos que adivinar
            String[] palabras_rnd = { "cacahuete", "primavera", "cobaya", "estofado",
                "girasol", "ventana", "brisa", "caballo", "dibujar", "origami", "pimientos",
            "sushi", "compadre", "hermanas", "responsabilidad", "faena"};


            //Obtenemos una palabra aleatoriamente del 'array'
            try
            {
                String palabra_obt = palabras_rnd[rdn.Next(palabras_rnd.Length)];
                Console.WriteLine(palabra_obt);

                //Nos creamos 2 'array de chars'
                char[] palabra_array = palabra_obt.ToCharArray();
                char[] palabra_adivinar = new char[palabra_array.Length];

                //Rellenamos el segundo con guiones
                for (int i = 0; i < palabra_adivinar.GetLength(0); i++)
                {
                    if(palabra_adivinar[i] != ' ')
                    {
                        palabra_adivinar[i] = '_';
                    }              
                }

                //COMIENZA EL JUEGO
                Console.WriteLine("ADIVINA LA PALABRA: ");

                for (int i = 0; i < max_errores && !palabraAdivinada;)
                {
                    try
                    {
                        imprimir_palabra(palabra_adivinar);

                        Console.Write("\n\nInserte una letra: ");
                        letra = Convert.ToChar(Console.ReadLine());


                        letraAdivinada = comprobar_letra(palabra_array, palabra_adivinar, letra);
                        if (!letraAdivinada)
                        {
                            i++;
                        }

                        palabraAdivinada = comprobar_palabra(palabra_adivinar);

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Debe insertar únicamente eun letra");
                    }

                }

                //Damos un mensaje
                if (palabraAdivinada)
                {
                    Console.WriteLine("\n¡Enhorabuena, ha acertado!");
                }
                else
                {
                    Console.WriteLine("\nLA palabra era '" + palabra_obt + "'.\nSuerte para la próxima vez.");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Se ha accedido a un elemento inexistente");
            }
            

            
            

            /*
            //TODO FOR
            //String palabra_adivinar = palabra_obt.Replace('_');
            //Console.WriteLine( palabra_adivinar);


            Console.WriteLine("La palabra correcta es: " + palabra_obt);
            */
        }
    }
}
