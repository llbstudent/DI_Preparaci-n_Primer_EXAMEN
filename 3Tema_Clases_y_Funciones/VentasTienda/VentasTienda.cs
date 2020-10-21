using System;

namespace VentasTiendaSemanales
{
	class VentasTienda
	{
		//Método que nos rellenará el ARRAY
		public static void rellenarArray(Venta[] ventas)
		{
			String[] diaSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"}; 

			for (int i = 0; i < ventas.Length; i++)
			{
				Console.Write("Día " + (i+1) + " - " + diaSemana[i] + ": ");
				Venta venta_aux = new Venta();
				venta_aux.DIA = diaSemana[i];
				venta_aux.GANANCIA = Convert.ToDouble(Console.ReadLine());
				ventas[i] = venta_aux;
				
				/*ventas[i] = new Venta();
				ventas[i].DIA = diaSemana[i];
				ventas[i].GANANCIA = Convert.ToDouble(Console.ReadLine());*/
			}

		}

		//Método que nos imprimirá el ARRAY
		public static void imprimirVentas(Venta[] ventasSemana)
		{
			for (int i = 0; i < ventasSemana.Length; i++)
			{
				Console.WriteLine(ventasSemana[i].DIA + " - Ventas: \t" + ventasSemana[i].GANANCIA);
			}
		}


		//Método que nos ordenará las ventas de mayor a menor
		public static void ordenaVentas(Venta[] ventasSemana)
		{
			Boolean modificacion = false;
			Venta ven_aux = new Venta();

			do
			{
				modificacion = false;

				for (int i = 0; i < ventasSemana.Length - 1; i++)
				{
					if (ventasSemana[i].GANANCIA < ventasSemana[i + 1].GANANCIA)
					{
						ven_aux = ventasSemana[i];
						ventasSemana[i] = ventasSemana[i + 1];
						ventasSemana[i + 1] = ven_aux;

						modificacion = true;
					}
				}
			} while (modificacion);

			//Imprimimos
			imprimirVentas(ventasSemana);
		}


		//Obtenemos el día de menos ventas
		public static String obtenerDiaMenosVentas(Venta[] ventasSemana)
		{
			Venta v1 = new Venta();

			for (int i = 0; i < ventasSemana.Length; i++)
			{
				if (i == 0){ v1 = ventasSemana[i];}

				if (v1.GANANCIA > ventasSemana[i].GANANCIA)
				{
					v1 = ventasSemana[i];
				}
			}

			return v1.toString();
		}

		//Obtenemos el día de más ventas
		public static String obtenerDiaMasVentas(Venta[] ventasSemana)
		{
			Venta v1 = new Venta();

			for (int i = 0; i < ventasSemana.Length; i++)
			{
				if (i == 0) { v1 = ventasSemana[i]; }

				if (v1.GANANCIA < ventasSemana[i].GANANCIA)
				{
					v1 = ventasSemana[i];
				}
			}
			return v1.toString();
		}

		//Obtenemos el total de ventas de la semana
		public static Double obtenerTotalVentasSemana(Venta[] ventasSemana)
		{
			Double total = 0;

			for (int i = 0; i < ventasSemana.Length; i++)
			{
				total += ventasSemana[i].GANANCIA;
			}

			return total;
		}

		//Obtenemos la media de las ventas de la semana
		public static Double obtenerMediaVentasSemana(Venta[] ventasSemana)
		{
			Double total = 0;

			for (int i = 0; i < ventasSemana.Length; i++)
			{
				total += ventasSemana[i].GANANCIA;
			}

			return total/ventasSemana.Length;
		}

		//MAIN
		static void Main(string[] args)
		{
			Boolean menuActivo = true;
			int opcion;
			Venta[] ventasSemana = new Venta[7];

			Console.WriteLine("RELLENE LAS VENTAS CON LAS GANANCIAS QUE HEMOS OBTENIDO ESTA SEMANA: " +
				"\n(para introducir decimales use la coma, no el punto:)\n");
			rellenarArray(ventasSemana);

			Console.WriteLine("\n\nVISUALIZACIÓN VENTAS DE LA SEMANA:");
			imprimirVentas(ventasSemana);


			//Menú
			do
			{
				Console.WriteLine("---------------------------------------");
				Console.WriteLine("\t\tMENU");
				Console.WriteLine("1- Ventas Ordenadas (Mayor - Menor)");
				Console.WriteLine("2- El día de más y menos ventas");
				Console.WriteLine("3- Total de ventas realizadas durante toda la semana");
				Console.WriteLine("4- Mostrar media de las ventas");
				Console.WriteLine("5- SALIR \n");

				Console.Write("Seleccione: ");
				opcion = Convert.ToInt32(Console.ReadLine());

				if (opcion == 1)
				{
					Console.WriteLine("VENTAS ORDENADAS:");
					ordenaVentas(ventasSemana);

				}
				else if (opcion == 2)
				{
					Console.WriteLine("DÍA CON MÁS Y MENOS VENTAS");

					Console.WriteLine("Día con menos ventas: " + obtenerDiaMenosVentas(ventasSemana) + "-EUROS");
					Console.WriteLine("Día con más ventas: " + obtenerDiaMasVentas(ventasSemana) + "-EUROS");

				}
				else if (opcion == 3)
				{
					Console.WriteLine("TOTAL DE VENTAS DE LA SEMANA");
					Console.WriteLine("Total: " + obtenerTotalVentasSemana(ventasSemana) + "-EUROS");
				}
				else if (opcion == 4)
				{
					Console.WriteLine("MEDIA DE LAS VENTAS DE LA SEMANA");
					Console.WriteLine("Media: " + obtenerMediaVentasSemana(ventasSemana) + "-EUROS");
				}
				else if (opcion == 5)
				{
					menuActivo = false;
					Console.WriteLine("ADIÓS");
				}
				else
				{
					Console.WriteLine("OPCIÓN NO VÁLIDA");
				}

			} while (menuActivo);
			
		}
	}
}
