using System;

namespace Ejercicio_Struct_Aulas
{
    //------------------------------------------------------------------------------------------------------------
    //  Los Struct
    // Aquí estarán definidas todas las estruturas que vamos a necesitar para poder realizar el ejercicio
    //------------------------------------------------------------------------------------------------------------

    //---------------------------
    //NOTAS
    //---------------------------
    public struct Notas
    {
        int[] notas;

        //Constructor
        public Notas(int numAsignaturas)
        {
            this.notas = new int[numAsignaturas];
        }

        //Setter Y Getter
        public int[] NOTAS_ASIGNATURAS
        {
            set { this.notas = value; }
            get { return this.notas; }
        }

        //ToString
        public override string ToString()
        {
            String notas = "\n\tNOTAS: ";
            for (int i=0; i < this.notas.Length; i++) {
                notas += this.notas[i] + " ";
            }
            return notas;
        }

        //Cambiar notas
        public void cambiarnotas()
        {
            try
            {
                for (int i = 0; i < this.notas.Length; i++)
                {
                    Console.Write((1 + i) + "-nota: ");
                    this.notas[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Alumno no existe en el sistema \n" + e);
            }
        }
    }


    //---------------------------
    //TUTOR
    //---------------------------
    public struct Tutor
    {
        String nombre;
        String asignaturaPrincipal;
        int annosDocencia;

        //Constructor
        public Tutor(String nombre, String asig, int annos)
        {
            this.nombre = nombre;
            this.asignaturaPrincipal = asig;
            this.annosDocencia = annos;
        }
        //Getter y Setter
        public String NOMBRE_PORF
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public String ASIGNATURA
        {
            set { this.asignaturaPrincipal = value; }
            get { return this.asignaturaPrincipal; }
        }

        public int ANNOS_DOCENCIA
        {
            set { this.annosDocencia = value; }
            get { return this.annosDocencia; }
        }

        //ToString
        public override string ToString()
        {
            return string.Format("\n\t-Nombre: {0}" +
                "\n\t-Años de docencia: {1}" +
                "\n\t-Asignatura principal: {2}",
                this.nombre, this.annosDocencia, this.asignaturaPrincipal);
        }

        //Para cambiar los datos
        internal void cambioDatos(String nombre, String asignatura, int annos)
        {
            this.nombre = nombre;
            this.asignaturaPrincipal = asignatura;
            this.annosDocencia = annos;
        }
    }

    //---------------------------
    //Alumno
    //---------------------------
    public struct Alumno
    {
        String nombre;
        int ID;
        String claveUsuario;
        DateTime fechaNacim;
        DateTime fechaIngresoInstituto;
        Tutor tutorCurso;
        Notas notasCurso;

        //Constructor
        public Alumno(String nombre, int ID, DateTime fechaNacim, DateTime fechaIngresoInstituto)
        {
            this.nombre = nombre;
            this.ID = ID;
            this.claveUsuario = "123456";
            this.fechaNacim = fechaNacim;
            this.fechaIngresoInstituto = fechaIngresoInstituto;
            this.tutorCurso = new Tutor("Luis Gómez", "Programación", 7); //Tutor por defecto (Sino nos morimos haciendo tutores)

            this.notasCurso = new Notas(5);
            Array.Fill(this.notasCurso.NOTAS_ASIGNATURAS, 5); //Rellenamos todas las asignaturas con un '5' (idem)           
        }

        //Setter y Getter
        public String NOMBRE
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public int ID_ALUMNO
        {
            set { this.ID = value; }
            get { return this.ID; }
        }

        public String CLAVE
        {
            set { this.claveUsuario = value; }
            get { return this.claveUsuario; }
        }

        public DateTime FECHA_NACIMINETO
        {
            set { this.fechaNacim = value; }
            get { return this.fechaNacim; }
        }

        public DateTime FECHA_INGRESO
        {
            set { this.fechaIngresoInstituto = value; }
            get { return this.fechaIngresoInstituto; }
        }


        public Tutor TUTOR
        {
            set { this.tutorCurso = value; }
            get { return this.tutorCurso; }
        }

        public Notas NOTAS
        {
            set { this.notasCurso = value; }
            get { return this.notasCurso; }
        }

        //ToString
        public override string ToString()
        {
            return string.Format("\n\n--------------------------------------" +
                "\n{0}-Alumno {1}" +
                "\nFecha Nacimiento: {2}" +
                "\nFecha ingreso Instituto: {3}" +
                "\nTutor: {4}" +
                "\nNotas: {5}"
                , this.ID, this.nombre, this.fechaNacim, this.fechaIngresoInstituto, this.tutorCurso, this.notasCurso);
        }

        //Método para cambiar la clave
        internal void cambiarClave()
        {
            Boolean presionATK = false;
            char teclaPulsada;
            String nueClave = "";
            Console.WriteLine("Inserte una clave. El símbolo '*' indicará el final de esta");

            do
            {
                teclaPulsada = Console.ReadKey(false).KeyChar;

                if (teclaPulsada == '*')
                    presionATK = true;
                else
                    nueClave += teclaPulsada;
            } while (!presionATK);

            this.claveUsuario = nueClave;
            Console.WriteLine("La nueva clave es \'{0}\'. no la pierda", this.claveUsuario);
        }
    }


    /// <summary>
    /// El programa principal, aquí se ejecutará todo el código
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Creación de los diferentes grupos de alumnos
            // Nos crearemos un array de arrays
            Alumno[][] aulas = new Alumno[3][];

            //El primer grupo tendrá 5 alumnos, el segundo 6 y el tercero 4
            aulas[0] = new Alumno[5];
            aulas[1] = new Alumno[6];
            aulas[2] = new Alumno[4];

            rellenarMatrizAlumnos(aulas);
            //Nos imprime la lista de alumnos completa: imprimirMatrizAlumnos(aulas);

            // nos ayudará a controlar las opciones principales del menú
            Boolean menuActivado = true;
            do
            {
                Console.WriteLine("\n------------------------------------" +
                    "\n[1]-Cambiar Notas a los alumnos" +
                    "\n[2]-Cambiar la clave del Alumno" +
                    "\n[3]-Cambiar los datos del tutor de un grupo" +
                    "\n[4]-Ver un grupo de alumnos" +
                    "\n[5]-SALIR");

                Console.Write("Seleccione: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                // Diferentes opciones:
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("HA ELEGIDO: Cambiar Notas a los alumnos");
                        //Cómo al final el ID es autonumerico, buscaremos a el alumno por ID
                        Console.Write("Elija a un alumno (1-15): ");
                        int alumID = Convert.ToInt32(Console.ReadLine());

                         Alumno alum = buscarAlumno_by_ID(alumID, aulas);
                         alum.NOTAS.cambiarnotas();
                         Console.WriteLine("Ver cambios: \n{0}", alum);
                        pulsarParaSeguir();
                        break;

                    case 2:
                        Console.WriteLine("HA ELEGIDO: Cambiar la clave del Alumno");
                        Console.Write("Elija a un alumno (1-15): ");
                        int alumID2 = Convert.ToInt32(Console.ReadLine());

                        Alumno alum2 = buscarAlumno_by_ID(alumID2, aulas);
                        alum2.cambiarClave();
                        pulsarParaSeguir();
                        break;

                    case 3:
                        //Este dato no se podrá cambiar debido a la manera en la que funcionan los struct
                        Console.WriteLine("HA ELEGIDO: Cambiar los datos del tutor");
                        Console.Write("Seleccione uno de los grupos (1-3): ");
                        int opcionGrupo = Convert.ToInt32(Console.ReadLine());

                        //Switch para los diferentes grupos
                        switch (opcionGrupo)
                        {
                            case 1:
                                cambiarDatosTutor(aulas[0]);
                                break;

                            case 2:
                                cambiarDatosTutor(aulas[1]);
                                break;

                            case 3:
                                cambiarDatosTutor(aulas[2]);
                                break;

                            default:
                                Console.WriteLine("Grupo no encontrado");
                                break;

                        }//Fin switchGrupo
                        pulsarParaSeguir();
                        break;

                    case 4:
                        Console.WriteLine("HA ELEGIDO: Ver un grupo de alumnos");
                        Console.Write("Seleccione uno de los grupos (1-3): ");
                        int opcionGrupo2 = Convert.ToInt32(Console.ReadLine());

                        //Switch para los diferentes grupos
                        switch (opcionGrupo2)
                        {
                            case 1:
                                imprimirGrupo(aulas[0]);
                                break;

                            case 2:
                                imprimirGrupo(aulas[1]);
                                break;

                            case 3:
                                imprimirGrupo(aulas[2]);
                                break;

                            default:
                                Console.WriteLine("Grupo no encontrado");
                                break;

                        }//Fin switchGrupo
                        pulsarParaSeguir();
                        break;

                    case 5:
                        Console.WriteLine("HASTA PRONTO");
                        menuActivado = false;
                        break;

                    default:
                        break;

                }//Fin switch
            } while (menuActivado);//Fin menu

            Console.ReadLine();
        }

        /// <summary>
        /// Nos imprimirá uno de los grupos de alumnos que le pasemos
        /// </summary>
        /// <param name="alumnos"></param>
        private static void imprimirGrupo(Alumno[] grupo)
        {
            for (int i = 0; i < grupo.Length; i++)
            {
                Console.WriteLine(grupo[i]);
            }
        }


        /// <summary>
        /// Método que nos ayudará a cambiar los datos del tutor iternamente
        /// </summary>
        /// <param name="alumnos"></param>
        private static void cambiarDatosTutor(Alumno[] grupoAlumnos)
        {
            Console.Write("Nombre Tutor: ");
            String nombre = Console.ReadLine();

            Console.Write("Asignatura Principal: ");
            String asig = Console.ReadLine();

            Console.Write("Años de docencia: ");
            int annos = Convert.ToInt32(Console.ReadLine());
            //Recorremos a los integrantes del grupo para cambiarle los datos
            for (int i=0; i < grupoAlumnos.Length; i++)
            {
                grupoAlumnos[i].TUTOR.cambioDatos(nombre, asig, annos);
            }
        }

        //Nos devuelve un alumno que coincida con el ID qu ele hemos pasado por parametro
        private static Alumno buscarAlumno_by_ID(int alumID, Alumno[][] aulas)
        {
            Alumno alumAux = new Alumno();
            for (int i = 0; i < aulas.Length; i++)
            {
                for (int j = 0; j < aulas[i].Length; j++)
                {
                    if (aulas[i][j].ID_ALUMNO == alumID)
                    {
                        alumAux =  aulas[i][j];
                    }
                }
            }
            return alumAux;
        }


        /// <summary>
        /// Nos imprime unos por uno a los alumnos de la respectiva Aula
        /// SobreEscribe el método 'toString'
        /// </summary>
        /// <param name="aulas"></param>
        private static void imprimirMatrizAlumnos(Alumno[][] aulas)
        {
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine((i + 1) + "-AULA");
                for (int j = 0; j < aulas[i].Length; j++)
                {
                    Console.WriteLine(aulas[i][j]);
                }
            }
        }

        /// <summary>
        /// Método que nos rellenará automáticamente la matriz que contendrá los grupos de los alumnos
        /// </summary>
        /// <param name="aulas"></param>
        private static void rellenarMatrizAlumnos(Alumno[][] aulas)
        {
            string pattern = "MM-dd-yy";
            for (int i = 0; i < aulas.Length; i++){
                for (int j = 0; j < aulas[i].Length; j++)
                {
                    aulas[i][j] = new Alumno("Pepito Perez", (i+1), new DateTime (2003, 6, 10), new DateTime(2016, 9, 10));
                }
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
            Console.WriteLine("\n\n\n ----- Pulse cualquier para seguir -----");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
