using System;

namespace DescomposicionSubcadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separadores = { ' ', ',', '.', ';', '!', '¡', '¿', '?' };
            Console.WriteLine("Inserte una cadena de texto (larga a ser posible): ");
            String cadena = Console.ReadLine();

            //Descomposicion
            String[] subcadena = cadena.Split(separadores);

            foreach (String palabra in subcadena)
            {
                int contador = 1;
                foreach (char letra in palabra)
                {
                    if(contador < 2)
                    {
                        Console.Write(letra);
                        contador++;
                    }
                    else
                    {
                        Console.Write(letra+ " ");
                        contador = 1;
                    }
                    
                }
                
            }
        }
    }
}
