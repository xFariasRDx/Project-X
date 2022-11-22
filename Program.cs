using System;

namespace project
{
    class principal
    {
        static void Main(string[] args)
        // todas las funcionalidades del programa estan en funciones, en un ciclo tal que retorna al menu principal al finalizar una funcion
        {
            MenuPrincipal();
            Console.ReadKey();
        }

        static void MenuPrincipal()
        {
            int input;
            Console.Clear();
            Console.WriteLine(@"
                ________ ________ _______ ____________________________________       ____  __
                ___  __ \___  __ \__  __ \______  /___  ____/__  ____/___  __/       __  |/ /
                __  /_/ /__  /_/ /_  / / /___ _  / __  __/   _  /     __  /          __    / 
                _  ____/ _  _, _/ / /_/ / / /_/ /  _  /___   / /___   _  /           _    |  
                /_/      /_/ |_|  \____/  \____/   /_____/   \____/   /_/            /_/|_|  
                                                                             
                                            ELECTRONIC DAIRY
                                            ----------------


                                          [PRESS ENTER TO START]
            ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(@"
                    M E N U   P R I N C I P A L
                    ---------------------------
                    
                        [1]      CONTACTOS.
                        [2]      EVENTOS.
                        [3]      UTILIDADES.
                        [4]      CALCULADORA.
                        [5]      SALIR.

                DIGITE EL NUMERO DE LA OPCION DESEADA: 
            ");

            //utilice un try catch para prevenir que el programa se cierre en caso de que se digite un valor que no sea numerico
            try
            {
                input = int.Parse(Console.ReadLine()!);


                switch (input)
                {
                    case 1:
                        // solamente tengo hecho hasta mostrar contactos, y aun tengo que hacer que devuevla al menu principal despues de terminar una funcion
                        Console.Clear();
                        Console.WriteLine("         QUE DESEA?");
                        Console.WriteLine("        -------------\n");
                        Console.WriteLine("[1]  INGRESAR CONTACTO.");
                        Console.WriteLine("[2]  MOSTRAR TODOS LOS CONTACTOS.");
                        Console.WriteLine("[3]  BUSCAR CONTACTOS.");
                        Console.WriteLine("[4]  EDITAR CONTACTO.");
                        Console.WriteLine("[5]  ELIMINAR CONTACTO.");
                        Console.WriteLine("[6]  RETROCEDER.");
                        input = int.Parse(Console.ReadLine()!);

                        switch (input)
                        {
                            case 1:
                                // los metodos para ingresar y mostrar contactos estan mas abajo, esos mismos se pueden reutilizar para los eventos, simplemente cambiando los parametros y las variables
                                Console.Clear();

                                ingresar(); //llamada a metodos los cuales estan desarrollados mas abajo
                                break;


                            case 2:
                                Console.Clear();
                                Console.WriteLine();
                                mostrar();  //llamada a metodos los cuales estan desarrollados mas abajo
                                break;



                            case 3:
                                Console.Clear();
                                Console.WriteLine();
                                buscar();  //llamada a metodos los cuales estan desarrollados mas abajo
                                break;

                            case 4:
                                Console.Clear();
                                editar();   //llamada a metodos los cuales estan desarrollados mas abajo
                                break;

                            case 5:
                                Console.Clear();
                                eliminar();   //llamada a metodos los cuales estan desarrollados mas abajo
                                break;

                            case 6:
                                {
                                    Console.Clear();
                                    Console.WriteLine("REGRESANDO...");
                                    Thread.Sleep(2000);
                                    MenuPrincipal();
                                }
                                break;
                            default: break;
                        }

                        break;


                    case 2:

                        // solamente tengo hecho hasta mostrar contactos, y aun tengo que hacer que devuevla al menu principal despues de terminar una funcion

                        Console.Clear();
                        Console.WriteLine("         QUE DESEA?");
                        Console.WriteLine("        -------------\n");
                        Console.WriteLine("[1]  INGRESAR EVENTO.");
                        Console.WriteLine("[2]  MOSTRAR TODOS LOS EVENTOS.");
                        Console.WriteLine("[3]  BUSCAR EVENTOS.");
                        Console.WriteLine("[4]  EDITAR EVENTOS.");
                        Console.WriteLine("[5]  ELIMINAR EVENTOS.");
                        Console.WriteLine("[6]  RETROCEDER.");

                        input = int.Parse(Console.ReadLine()!);

                        switch (input)
                        {
                            case 1:
                                {   // los metodos para ingresar y mostrar contactos estan mas abajo, esos mismos se pueden reutilizar para los eventos, simplemente cambiando los parametros y las variables
                                    Console.Clear();
                                    ingresarEvento();       //llamada a metodos los cuales estan desarrollados mas abajo
                                }
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine();
                                mostrarEvento();        //llamada a metodos los cuales estan desarrollados mas abajo
                                break;



                            case 3:
                                Console.Clear();
                                Console.WriteLine();
                                buscarEvento();         //llamada a metodos los cuales estan desarrollados mas abajo
                                break;

                            case 4:
                                Console.Clear();
                                editarEvento();         //llamada a metodos los cuales estan desarrollados mas abajo
                                break;

                            case 5:
                                Console.Clear();
                                eliminarEvento();       //llamada a metodos los cuales estan desarrollados mas abajo
                                break;

                            case 6:
                                {
                                    Console.Clear();
                                    Console.WriteLine("REGRESANDO...");
                                    Thread.Sleep(2000);
                                    MenuPrincipal();
                                }
                                break;

                            default:
                                {

                                }
                                break;
                        }
                        break;



                    case 3:
                        Console.Clear();
                        Console.WriteLine("         ");
                        Console.WriteLine("        \n");
                        Console.WriteLine(@"
                           QUE UTILIDAD DESEA?
                           -------------------
                                

                         [1]    GRADO MACHINE.
                         [2]    MONEY CONVERT.
                         [3]    RETROCEDER.
                             

                          SELECCIONE UNA OPCION:
                          ======================
                        ");
                        int num = Convert.ToInt32(Console.ReadLine()!);
                        switch (num)
                        {
                            case 1:
                                {
                                    GradoConvert();
                                }
                                break;
                            case 2:
                                {
                                    MoneyMachine();
                                }
                                break;
                            case 3:
                                {
                                    Console.Clear();
                                    Console.WriteLine("REGRESANDO...");
                                    Thread.Sleep(2000);
                                    MenuPrincipal();
                                }
                                break;

                            default:
                                {

                                }
                                break;

                        }
                        break;



                    case 4:
                        {
                            CALCULADORA();
                        }
                        break;


                    case 5:       //en este case el programa simplemente se cierra despues de pulsar enter dos veces (le puse 2 veces pa hacerlo original XD)
                        {
                            Console.WriteLine("PRESIONE ENTER 2 VECES PARA CERRAR EL PROGRAMA");
                            Console.ReadKey();
                        }
                        break;

                    default:
                        {

                        }
                        break;
                }




            }
            catch (FormatException) // en caso de que se digite un valor no numerico, se ejecuaran estas instrucciones
            {
                Console.Clear();
                Console.WriteLine("NO HAS INTRODUCIDO UN VALOR VALIDO");
                Console.WriteLine("PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
                Console.ReadKey();
                MenuPrincipal();
            }

        }

        // metodo para ingresar contactos
        public static void ingresar()
        {


            long contador = 0;

            string[] arraycontac = new string[10000];
            string nombre, tel, linea, apellido, direccion, email;

            int i = 0;


            // debe haber un archivo llamado "Info.dat" en la carpeta del ejecutable del programa
            StreamWriter dat;
            StreamReader lectura;
            if (!File.Exists("Info.dat"))// Por si la moca y el archivo no existe
            {
                dat = File.CreateText("Info.dat");// se crea el archivo
                dat.Close();// aqui se cierra la conexion con el archivo
            }
            else
            {
                lectura = File.OpenText("Info.dat");

                do
                {

                    linea = lectura.ReadLine()!;
                    arraycontac[i] = linea;
                    //Console.WriteLine("{0}",arraycontac[i]);
                    i += 1;
                    contador += 1;

                }
                while (linea != null);
                lectura.Close();
                contador -= 1;
                Console.WriteLine("CONTACTO #{0}", contador);
                //termina codigo en comun
            }

            StreamWriter infor;
            Console.WriteLine("INTRODUCE EL NOMBRE DEL CONTACTO");
            nombre = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE EL APELLIDO DE {0}", nombre);
            apellido = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE EL TELEFONO DE {0}", nombre);
            tel = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE LA DIRECCION DE {0}", nombre);
            direccion = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE EL EMAIL DE {0}", nombre);
            email = Console.ReadLine()!;

            arraycontac[contador] = ($"        {nombre}           {apellido}           {tel}                {direccion}                {email}");

            infor = File.AppendText("Info.dat");
            infor.WriteLine("{0} ", arraycontac[contador]);
            infor.Close();

            contador += 1;



            Console.WriteLine("PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
            Console.ReadKey();
            MenuPrincipal();
        }

        // metodo para mostrar contactos
        public static void mostrar()
        {
            StreamWriter dasto;
            if (!File.Exists("Info.dat"))           // Por si la moca y el archivo no existe
            {
                dasto = File.CreateText("Info.dat");// se crea el archivo
                dasto.Close();// aqui se cierra la conexion con el archivo
            }

            StreamReader lectura = new StreamReader("Info.dat");
            string linea;



            try
            {
                linea = lectura.ReadLine()!;  //lee todas las lineas
                Console.WriteLine("        |NOMBRE|             |APELLIDO|            |TEL|                 |DIRECCION|                  |EMAIL|");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                while (linea != null)
                {
                    Console.WriteLine(linea);
                    Console.WriteLine();
                    linea = lectura.ReadLine()!;
                }
                lectura.Close();
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
            Console.ReadKey();
            MenuPrincipal();
        }
        // metodo para buscar contactos
        public static void buscar()
        {
            long contador = 0;

            string[] arraycontac = new string[10000];
            string linea, buscar;

            int i = 0;


            // debe haber un archivo llamado "Info.dat" en la carpeta del ejecutable del programa
            StreamWriter dat;
            StreamReader lectura;
            if (!File.Exists("Info.dat"))// Por si la moca y el archivo no existe
            {
                dat = File.CreateText("Info.dat");// se crea el archivo
                dat.Close();// aqui se cierra la conexion con el archivo
            }
            else
            {
                lectura = File.OpenText("Info.dat");

                do
                {

                    linea = lectura.ReadLine()!;
                    arraycontac[i] = linea;
                    //Console.WriteLine("{0}",arraycontac[i]);
                    i += 1;
                    contador += 1;

                }

                while (linea != null);
                lectura.Close();
                contador -= 1;
                Console.WriteLine("{0}", contador);
                //termina codigo en comun
            }


            Console.Clear();
            Console.WriteLine("INTRODUCE UN NOMBRE O NUMERO DE TELEFONO PARA BUSCAR");
            buscar = Console.ReadLine()!;
            Console.Clear();
            Console.WriteLine("        |NOMBRE|             |APELLIDO|            |TEL|                 |DIRECCION|                  |EMAIL|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (i = 0; i < contador; i++)

                if (arraycontac[i].IndexOf(buscar) >= 0)
                    Console.WriteLine("{0}", arraycontac[i]);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
            Console.ReadLine();
            MenuPrincipal();
        }

        //metodo para eliminar contactos
        public static void eliminar()
        {

            long contador = 0;

            string[] arraycontac = new string[10000];
            string linea, siono, buscar;

            int i = 0, e = 0;

            // debe haber un archivo llamado "Info.dat" en la carpeta del ejecutable del programa
            StreamWriter dat;
            StreamReader lectura;
            if (!File.Exists("Info.dat"))// Por si la moca y el archivo no existe
            {
                dat = File.CreateText("Info.dat");// se crea el archivo
                dat.Close();// aqui se cierra la conexion con el archivo
            }
            else
            {
                lectura = File.OpenText("Info.dat");

                do
                {

                    linea = lectura.ReadLine()!;
                    arraycontac[i] = linea;
                    //Console.WriteLine("{0}",arraycontac[i]);
                    i += 1;
                    contador += 1;

                }
                while (linea != null);
                lectura.Close();
                contador -= 1;      // para poder sobreescribir la posicion en la cual se elimino (Contacto = Posicion.)
                Console.WriteLine("{0}", contador);

                //termina codigo en comun
            }


            StreamWriter datoss;// Declaramos la Clase para escribir en archivos en la variable datos..
            //                      Declaramos una variable de escritura escribir en el archivo.
            Console.Clear();
            Console.WriteLine("INTRODUCE UN NOMBRE O NUMERO DE TELEFONO PARA ELIMINAR");
            buscar = Convert.ToString(Console.ReadLine()!);

            for (i = 0; i < contador; i++)
            {
                if (arraycontac[i].IndexOf(buscar) >= 0)   // indexof: busca coincidencia en el arreglo.
                {
                    int s;
                    for (s = i; s < contador - 1; s++)
                        arraycontac[s] = arraycontac[s + 1];  // recorre el arreglo de una forma distinta del arreglo para replanzar la posicion de turno por un string sin caracteres.
                    contador--;
                    arraycontac[contador] = "";
                }
            }
            siono = Convert.ToString(Console.ReadLine()!); //Nama para que precione Enter de parte del user.
            dat = File.CreateText("Info.dat");// Agregamos el texto..
            dat.Close();// Cerramos el archivo.. o sea, la conexion con el archivo.

            for (e = 0; e < contador; e++)
            {
                datoss = File.AppendText("Info.dat");// Abrimos para editar el archivo.. // usamos appendtext para agregar la modificaciones al archivo
                datoss.WriteLine("{0} ", arraycontac[e]);
                datoss.Close();

            }
            Console.WriteLine("CONTACTO ELIMINADO CORRECTAMENTE");
            Console.WriteLine();
            Console.WriteLine("PRESIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
            Console.ReadLine();
            MenuPrincipal();



        }
        //metodo para editar contactos
        public static void editar()
        {
            long contador = 0;

            string[] arraycontac = new string[10000];
            string nombre, tel, linea, buscar, apellido, direccion, email;

            int i = 0, e = 0;

            // debe haber un archivo llamado "Info.dat" en la carpeta del ejecutable del programa
            StreamWriter dat;
            StreamReader lectura;
            if (!File.Exists("Info.dat"))// Por si la moca y el archivo no existe
            {
                dat = File.CreateText("Info.dat");// se crea el archivo
                dat.Close();// aqui se cierra la conexion con el archivo
            }
            else
            {
                lectura = File.OpenText("Info.dat");

                do
                {

                    linea = lectura.ReadLine()!;
                    arraycontac[i] = linea;
                    //Console.WriteLine("{0}",arraycontac[i]);
                    i += 1;
                    contador += 1;

                }
                while (linea != null);
                lectura.Close();
                contador -= 1;
                Console.WriteLine("{0}", contador);
                //termina codigo en comun
            }



            StreamWriter datoss;// Declaramos la Clase para escribir en archivos en la variable datos..

            Console.Clear();
            Console.WriteLine("INTRODUCE UN NOMBRE O NUMERO DE TELEFONO PARA EDITAR");
            buscar = Convert.ToString(Console.ReadLine()!);

            for (i = 0; i < contador; i++)
            {
                if (arraycontac[i].IndexOf(buscar) >= 0)
                {
                    int s;
                    for (s = i; s < contador - 1; s++)
                        arraycontac[s] = arraycontac[s + 1];
                    contador--;
                    arraycontac[contador] = "";
                }
            }
            dat = File.CreateText("Info.dat");// Creamos el archivo..
            dat.Close();// Cerramos el archivo..

            for (e = 0; e < contador; e++)
            {
                datoss = File.AppendText("Info.dat");// Abrimos para editar el archivo..
                datoss.WriteLine("{0} ", arraycontac[e]);
                datoss.Close();

            }

            StreamWriter infor;
            Console.WriteLine("INTRODUCE EL NUEVO NOMBRE DEL CONTACTO");
            nombre = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE EL APELLIDO DE {0}", nombre);
            apellido = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE EL TELEFONO DE  {0}", nombre);
            tel = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE LA DIRECCION DE {0}", nombre);
            direccion = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE EL EMAIL DE {0}", nombre);
            email = Console.ReadLine()!;

            arraycontac[contador] = ($"        {nombre}           {apellido}           {tel}                {direccion}                {email}");

            infor = File.AppendText("Info.dat");
            infor.WriteLine("{0} ", arraycontac[contador]);
            infor.Close();

            contador += 1;




            Console.WriteLine();
            Console.WriteLine("PRESIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
            Console.ReadLine();
            MenuPrincipal();

        }



        //------------------------------------Func-Eventos-------------------------------------------------

        public static void ingresarEvento()
        {


            long EventoC = 0;

            string[] arrayEvento = new string[10000];
            string nombreevento, fecha, lineaEVE, hora, lugar;

            int i = 0;


            // debe haber un archivo llamado "Info.dat" en la carpeta del ejecutable del programa
            StreamWriter datEVE;
            StreamReader lecturaEVE;
            if (!File.Exists("Evento.dat"))// Por si la moca y el archivo no existe
            {
                datEVE = File.CreateText("Evento.dat");// se crea el archivo
                datEVE.Close();// aqui se cierra la conexion con el archivo
            }
            else
            {
                lecturaEVE = File.OpenText("Evento.dat");

                do
                {

                    lineaEVE = lecturaEVE.ReadLine()!;
                    arrayEvento[i] = lineaEVE;
                    //Console.WriteLine("{0}",arraycontac[i]);
                    i += 1;
                    EventoC += 1;

                }
                while (lineaEVE != null);
                lecturaEVE.Close();
                EventoC -= 1;
                Console.WriteLine("Contacto #{0}", EventoC);
                //termina codigo en comun
            }

            StreamWriter inforEVE;
            Console.WriteLine("INTRODUCE EL NOMBRE DEL EVENTO");
            nombreevento = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE LA FECHA DEL EVENTO");
            fecha = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE LA HORA DEL EVENTO");
            hora = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE EL LUGAR DEL EVENTO");
            lugar = Console.ReadLine()!;


            arrayEvento[EventoC] = ($"       {nombreevento}              {fecha}                  {hora}              {lugar}");

            inforEVE = File.AppendText("Evento.dat");
            inforEVE.WriteLine("{0} ", arrayEvento[EventoC]);
            inforEVE.Close();

            EventoC += 1;



            Console.WriteLine("PRESIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
            Console.ReadKey();
            MenuPrincipal();
        }

        public static void mostrarEvento()
        {
            StreamWriter dastoEve;
            if (!File.Exists("Evento.dat"))// Por si la moca y el archivo no existe
            {
                dastoEve = File.CreateText("Evento.dat");// se crea el archivo
                dastoEve.Close();// aqui se cierra la conexion con el archivo
            }

            StreamReader lecturaEve = new StreamReader("Evento.dat");
            string lineaEVE;



            try
            {
                lineaEVE = lecturaEve.ReadLine()!;
                Console.WriteLine("       |NOMBRE|               |FECHA|                   |HORA|                |LUGAR|");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                while (lineaEVE != null)
                {
                    Console.WriteLine(lineaEVE);
                    Console.WriteLine();
                    lineaEVE = lecturaEve.ReadLine()!;
                }
                lecturaEve.Close();
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("PRESIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
            Console.ReadKey();
            MenuPrincipal();
        }

        public static void buscarEvento()
        {
            long EventoC = 0;

            string[] arrayEvento = new string[10000];
            string lineaEVE, buscarEve;

            int i = 0;


            // debe haber un archivo llamado "Info.dat" en la carpeta del ejecutable del programa
            StreamWriter datEVE;
            StreamReader lecturaEVE;
            if (!File.Exists("Evento.dat"))// Por si la moca y el archivo no existe
            {
                datEVE = File.CreateText("Evento.dat");// se crea el archivo
                datEVE.Close();// aqui se cierra la conexion con el archivo
            }
            else
            {
                lecturaEVE = File.OpenText("Evento.dat");

                do
                {

                    lineaEVE = lecturaEVE.ReadLine()!;
                    arrayEvento[i] = lineaEVE;
                    //Console.WriteLine("{0}",arraycontac[i]);
                    i += 1;
                    EventoC += 1;

                }

                while (lineaEVE != null);
                lecturaEVE.Close();
                EventoC -= 1;
                Console.WriteLine("{0}", EventoC);
                //termina codigo en comun
            }


            Console.Clear();
            Console.WriteLine("INTRODUCE EL NOMBRE O FECHA PARA BUSCAR");
            buscarEve = Console.ReadLine()!;
            Console.Clear();
            Console.WriteLine("       |NOMBRE|               |FECHA|                   |HORA|                |LUGAR|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (i = 0; i < EventoC; i++)

                if (arrayEvento[i].IndexOf(buscarEve) >= 0)
                    Console.WriteLine("{0}", arrayEvento[i]);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("PRECIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
            Console.ReadLine();
            MenuPrincipal();
        }

        public static void eliminarEvento()
        {

            long EventoC = 0;

            string[] arrayEvento = new string[10000];
            string lineaEVE, sionoEve, buscarEve;

            int i = 0, e = 0;

            // debe haber un archivo llamado "Info.dat" en la carpeta del ejecutable del programa
            StreamWriter datEve;
            StreamReader lecturaEve;
            if (!File.Exists("Evento.dat"))// Por si la moca y el archivo no existe
            {
                datEve = File.CreateText("Evento.dat");// se crea el archivo
                datEve.Close();// aqui se cierra la conexion con el archivo
            }
            else
            {
                lecturaEve = File.OpenText("Evento.dat");

                do
                {

                    lineaEVE = lecturaEve.ReadLine()!;
                    arrayEvento[i] = lineaEVE;
                    //Console.WriteLine("{0}",arraycontac[i]);
                    i += 1;
                    EventoC += 1;

                }
                while (lineaEVE != null);
                lecturaEve.Close();
                EventoC -= 1;
                Console.WriteLine("{0}", EventoC);
                //termina codigo en comun
            }


            StreamWriter datossEve;// Declaramos la Clase para escribir en archivos en la variable datos..

            Console.Clear();
            Console.WriteLine("INTRODUCE EL NOMBRE PARA ELIMINAR");
            buscarEve = Convert.ToString(Console.ReadLine()!);

            for (i = 0; i < EventoC; i++)
            {
                if (arrayEvento[i].IndexOf(buscarEve) >= 0)
                {
                    int s;
                    for (s = i; s < EventoC - 1; s++)
                        arrayEvento[s] = arrayEvento[s + 1];
                    EventoC--;
                    arrayEvento[EventoC] = "";
                }
            }
            sionoEve = Convert.ToString(Console.ReadLine()!);
            datEve = File.CreateText("Evento.dat");// Creamos el archivo..
            datEve.Close();// Cerramos el archivo..

            for (e = 0; e < EventoC; e++)
            {
                datossEve = File.AppendText("Evento.dat");// Abrimos para editar el archivo..
                datossEve.WriteLine("{0} ", arrayEvento[e]);
                datossEve.Close();

            }
            Console.WriteLine("EVENTO ELIMINADO CORRECTAMENTE");
            Console.WriteLine();
            Console.WriteLine("PRESIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
            Console.ReadLine();
            MenuPrincipal();



        }

        public static void editarEvento()
        {
            long EventoC = 0;

            string[] arrayEvento = new string[10000];
            string nombreevento, fecha, hora, lugar, lineaEVE, buscarEVE;

            int i = 0, e = 0;

            // debe haber un archivo llamado "Info.dat" en la carpeta del ejecutable del programa
            StreamWriter datEVE;
            StreamReader lecturaEVE;
            if (!File.Exists("Evento.dat"))// Por si la moca y el archivo no existe
            {
                datEVE = File.CreateText("Evento.dat");// se crea el archivo
                datEVE.Close();// aqui se cierra la conexion con el archivo
            }
            else
            {
                lecturaEVE = File.OpenText("Evento.dat");

                do
                {

                    lineaEVE = lecturaEVE.ReadLine()!;
                    arrayEvento[i] = lineaEVE;
                    //Console.WriteLine("{0}",arraycontac[i]);
                    i += 1;
                    EventoC += 1;

                }
                while (lineaEVE != null);
                lecturaEVE.Close();
                EventoC -= 1;
                Console.WriteLine("{0}", EventoC);
                //termina codigo en comun
            }



            StreamWriter datossEVE;// Declaramos la Clase para escribir en archivos en la variable datos..

            Console.Clear();
            Console.WriteLine("INTRODUCE EL NOMBRE PARA EDITAR");
            buscarEVE = Convert.ToString(Console.ReadLine()!);

            for (i = 0; i < EventoC; i++)
            {
                if (arrayEvento[i].IndexOf(buscarEVE) >= 0)
                {
                    int s;
                    for (s = i; s < EventoC - 1; s++)
                        arrayEvento[s] = arrayEvento[s + 1];
                    EventoC--;
                    arrayEvento[EventoC] = "";
                }
            }
            datEVE = File.CreateText("Evento.dat");// Creamos el archivo..
            datEVE.Close();// Cerramos el archivo..

            for (e = 0; e < EventoC; e++)
            {
                datossEVE = File.AppendText("Evento.dat");// Abrimos para editar el archivo..
                datossEVE.WriteLine("{0} ", arrayEvento[e]);
                datossEVE.Close();

            }

            StreamWriter inforEve;
            Console.WriteLine("INTRODUCE EL NUEVO NOMBRE DEL EVENTO");
            nombreevento = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE LA NUEVA FECHA");
            fecha = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE LA NUEVA HORA");
            hora = Console.ReadLine()!;
            Console.WriteLine("INTRODUCE LA NUEVA DIRECCION");
            lugar = Console.ReadLine()!;

            arrayEvento[EventoC] = ($"       {nombreevento}              {fecha}                  {hora}              {lugar}");

            inforEve = File.AppendText("Evento.dat");
            inforEve.WriteLine("{0} ", arrayEvento[EventoC]);
            inforEve.Close();

            EventoC += 1;




            Console.WriteLine();
            Console.WriteLine("PRESIONE ENTER PARA VOLVER AL MENU PRINCIPAL");
            Console.ReadLine();
            MenuPrincipal();

        }

        //#------------------------------------FUNCIONES DE UTILIDADES------------------------------------------------#

        public static void GradoConvert()
        {
            Console.Clear();
            Console.WriteLine(@"
               ___                                   ,__ __               _                    
              / (_)                                 /|  |  |             | |    o              
             |      __   _  _         _   ,_  _|_    |  |  |   __,   __  | |        _  _    _  
             |     /  \_/ |/ |  |  |_|/  /  |  |     |  |  |  /  |  /    |/ \   |  / |/ |  |/  
              \___/\__/   |  |_/ \/  |__/   |_/|_/   |  |  |_/\_/|_/\___/|   |_/|_/  |  |_/|__/
                                                                                                
                                                                                                                                                                                        
            ");
            Console.WriteLine("                                       PRESS ENTER TO START");
            Console.WriteLine("                                       --------------------");
            Console.ReadKey();
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(@"
                        MENU
                        ----

                [1]     CELSIUS.
                [2]     FAHRENHEIT.
                [3]     KELVIN.
                [4]     EXIT.
                
                ");


                Console.WriteLine("            SELECCIONE LA OPCION QUE DESEA: ");
                Console.WriteLine("            =============================== ");
                opcion = int.Parse(Console.ReadLine()!);


                switch (opcion)
                {

                    //  CONVERSION DE CELSIUS.
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine(@"
                        A QUE UNIDAD DESEA COMVERTIR?
                        -----------------------------

                            [1] FAHRENHEIT.

                            [2] KELVIN.
                        ");

                            int opcion1 = Convert.ToInt32(Console.ReadLine()!);
                            switch (opcion1)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("CONVIRTIENDO DE CELSIUS A FAHRENHEIT.");
                                        Console.WriteLine("-------------------------------------");
                                        Console.WriteLine("INTRODUZA GRADO A CONVERTIR: ");
                                        double num = Convert.ToDouble(Console.ReadLine()!);
                                        // double Resultado = ((num * 9/5) + 32);
                                        Console.Clear();
                                        Console.WriteLine($"{num}°C CONVERTIDOS A FAHRENHEIT ES IGUAL A: {CelsiusToFarenheit(num)} °F");
                                        Console.ReadKey();
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("CONVIRTIENDO DE CELSIUS A KELVIN");
                                        Console.WriteLine("--------------------------------");
                                        Console.WriteLine("INTRODUZA GRADO A CONVERTIR: ");
                                        double num = Convert.ToDouble(Console.ReadLine()!);
                                        //double Resultado = (num + 273.15);
                                        Console.Clear();
                                        Console.WriteLine($"{num}°C CONVERTIDOS A KELVIN ES IGUAL A: {CelsiusToKelvin(num)} °K");
                                        Console.ReadKey();
                                    }
                                    break;

                                default:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("SELECCION INCORRECTA!");
                                        Console.ReadKey();
                                    }
                                    break;

                            }

                        }
                        break;


                    //  CONVERSION DE FAHRENHEIT.

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine(@"
                        A QUE UNIDAD DESEA COMVERTIR?
                        -----------------------------
                        
                            [1] CELSIUS.

                            [2] KELVIN.
                        ");

                            int opcion1 = Convert.ToInt32(Console.ReadLine()!);
                            switch (opcion1)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("CONVIRTIENDO DE FAHRENHEIT A CELSIUS.");
                                        Console.WriteLine("-------------------------------------");
                                        Console.WriteLine("INTRODUZA GRADO A CONVERTIR: ");
                                        double num = Convert.ToDouble(Console.ReadLine()!);
                                        double Resultado = ((num - 32) * 5 / 9);
                                        Console.Clear();
                                        Console.WriteLine($"{num}°F CONVERTIDOS A CELSIUS ES IGUAL A: {Resultado} °C");
                                        Console.ReadKey();
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("CONVIRTIENDO DE FAHRENHEIT A KELVIN.");
                                        Console.WriteLine("------------------------------------");
                                        Console.WriteLine("INTRODUZA GRADO A CONVERTIR: ");
                                        double num = Convert.ToDouble(Console.ReadLine()!);
                                        double Resultado = (((num - 32) * 5 / 9) + 273.15);
                                        Console.Clear();
                                        Console.WriteLine($"{num}°F CONVERTIDOS A KELVIN ES IGUAL A: {Resultado} °K");
                                        Console.ReadKey();
                                    }
                                    break;

                                default:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("SELECCION INCORRECTA!");
                                    }
                                    break;

                            }

                        }
                        break;

                    // CONVERSION DE KELVIN

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine(@"
                        A QUE UNIDAD DESEA COMVERTIR?
                        -----------------------------

                            [1] CELSIUS.
                        
                            [2] FAHRENHEIT.
                        ");

                            int opcion1 = Convert.ToInt32(Console.ReadLine()!);
                            switch (opcion1)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("CONVIRTIENDO DE KELVIN A CELSIUS.");
                                        Console.WriteLine("---------------------------------");
                                        Console.WriteLine("INTRODUZA GRADO A CONVERTIR: ");
                                        double num = Convert.ToDouble(Console.ReadLine()!);
                                        double Resultado = (num - 273.15);
                                        Console.Clear();
                                        Console.WriteLine($"{num}°K CONVERTIDOS A CELSIUS ES IGUAL A: {Resultado} °C");
                                        Console.ReadKey();
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("CONVIRTIENDO DE KELVIN A FAHRENHEIT.");
                                        Console.WriteLine("------------------------------------");
                                        Console.WriteLine("INTRODUZA GRADO A CONVERTIR: ");
                                        double num = Convert.ToDouble(Console.ReadLine()!);
                                        double Resultado = (((num - 273.15) * 9 / 5) + 32);
                                        Console.Clear();
                                        Console.WriteLine($"{num}°C CONVERTIDOS A KELVIN ES IGUAL A: {Resultado} °F");
                                        Console.ReadKey();
                                    }
                                    break;

                            }
                        }
                        break;


                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("CERRANDO APP...");
                            Thread.Sleep(3000);
                        }
                        break;

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("PANA USTED VE ESA OPCION?");
                            Console.ReadKey();
                        }
                        break;
                }

            }
            while (opcion != 4);

            MenuPrincipal();
        }



        //     FUNCIONES DE GRADO-CONVERT    //
        public static double CelsiusToFarenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        public static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }


        public static void MoneyMachine()
        {
            // START.
            Console.Clear();

            Console.WriteLine(@"
                ______  ___                                  _________                                     _____ 
                ___   |/  /______ _______ _____ _____  __    __  ____/______ _______ ___   _______ __________  /_
                __  /|_/ / _  __ \__  __ \_  _ \__  / / /    _  /     _  __ \__  __ \__ | / /_  _ \__  ___/_  __/
                _  /  / /  / /_/ /_  / / //  __/_  /_/ /     / /___   / /_/ /_  / / /__ |/ / /  __/_  /    / /_  
                /_/  /_/   \____/ /_/ /_/ \___/ _\__, /      \____/   \____/ /_/ /_/ _____/  \___/ /_/     \__/  
                                                /____/                                                           
            ");
            Console.WriteLine("                                                   PRESS ENTER TO START");
            Console.WriteLine("                                                   --------------------");
            Console.ReadKey();
            int opcion = 0;
            do
            {
                //Console.Clear();
                Console.WriteLine(@"

                                                        MENU
                                                        ----
                                                
                                                [1]    (RD$) - PESO.
                                                [2]    (US$) - DOLLAR.
                                                [3]    (E$)  - EURO.
                                                [4]         EXIT.
                                            
                                            SELECCIONE LA MONEDA QUE POSEE: 
                                            ==============================
                ");

                opcion = int.Parse(Console.ReadLine()!);
                switch (opcion)
                {
                    //  CONVERSION DE PESO.
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine(@"
                        A QUE UNIDAD DESEA COMVERTIR?
                        -----------------------------

                            [1]    (US$) - DOLLAR.
                            [2]    (E$)  - EURO.
                        ");

                            int opcion1 = Convert.ToInt32(Console.ReadLine()!);
                            switch (opcion1)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("CONVIRTIENDO A DOLLAR: ");
                                        Console.WriteLine("-----------------------");
                                        Console.WriteLine("INTRODUZCA LA CANTIDAD: ");
                                        int num = Convert.ToInt32(Console.ReadLine()!);
                                        Console.Clear();
                                        Console.WriteLine($"[RD$ {num}] EN DOLLAR ES IGUAL A: [{PesosToDolares(num)} $US]");
                                        Console.ReadKey();
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("CONVIRTIENDO A EURO");
                                        Console.WriteLine("-------------------");
                                        Console.WriteLine("INTRODUZCA LA CANTIDAD: ");
                                        int num = Convert.ToInt32(Console.ReadLine()!);
                                        Console.Clear();
                                        Console.WriteLine($"[RD$ {num}] EN EURO ES IGUAL A: [{PesosToEuros(num)} EU$]");
                                        Console.ReadKey();

                                    }
                                    break;

                                default:
                                    {
                                        Console.WriteLine("RELOADING...");
                                        Console.WriteLine("------------");
                                        Thread.Sleep(3000);
                                    }
                                    break;

                            }

                        }
                        break;

                    //  CONVERSION DE DOLLAR.

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine(@"
                        A QUE UNIDAD DESEA COMVERTIR?
                        -----------------------------

                            [1]    (RD$) - PESO.
                            [2]    (EU$) - EURO.
                        ");

                            int opcion1 = Convert.ToInt32(Console.ReadLine()!);
                            switch (opcion1)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("CONVIRTIENDO A PESO: ");
                                        Console.WriteLine("INTRODUZCA LA CANTIDAD: ");
                                        int num = Convert.ToInt32(Console.ReadLine()!);
                                        Console.Clear();
                                        Console.WriteLine($"[US$ {num}] EN PESO ES IGUAL A: [{DollarToPeso(num)} RD$]");
                                        Console.ReadKey();
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("CONVIRTIENDO A EURO");
                                        Console.WriteLine("INTRODUZCA LA CANTIDAD: ");
                                        int num = Convert.ToInt32(Console.ReadLine()!);
                                        Console.Clear();
                                        Console.WriteLine($"[US$ {num}] EN EURO ES IGUAL A: [{DollarToEuro(num)} EU$]");
                                        Console.ReadKey();

                                    }
                                    break;

                                default:
                                    {
                                        Console.WriteLine("RELOADING...");
                                    }
                                    break;
                            }
                        }
                        break;

                    // CONVERSION DE EURO.

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine(@"
                        A QUE UNIDAD DESEA COMVERTIR?
                        -----------------------------

                            [1]    (RD$) - PESO.
                            [2]    (US$) - DOLLAR.
                        ");

                            int opcion1 = Convert.ToInt32(Console.ReadLine()!);
                            switch (opcion1)
                            {
                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("CONVIRTIENDO A PESO: ");
                                        Console.WriteLine("INTRODUZCA LA CANTIDAD: ");
                                        int num = Convert.ToInt32(Console.ReadLine()!);
                                        Console.Clear();
                                        Console.WriteLine($"[EU$ {num}] EN PESO ES IGUAL A: [{EuroToPeso(num)} RD$]");
                                        Console.ReadKey();
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("CONVIRTIENDO A DOLLAR");
                                        Console.WriteLine("INTRODUZCA LA CANTIDAD: ");
                                        int num = Convert.ToInt32(Console.ReadLine()!);
                                        Console.Clear();
                                        Console.WriteLine($"[EU$ {num}] EN DOLLAR ES IGUAL A: [{EuroToDollar(num)} US$]");
                                        Console.ReadKey();
                                    }
                                    break;

                                default:
                                    {
                                        Console.WriteLine("RELOADING...");
                                    }
                                    break;
                            }
                        }
                        break;

                    // SALIENDO.

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("CERRANDO APP...");
                            Thread.Sleep(3000);
                            MenuPrincipal();
                        }
                        break;


                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("USTED VE ESA OPCION?!");
                            Console.ReadKey();
                        }
                        break;
                }
                Console.Clear();

            } while (opcion != 4);
        }
        //##########################################################//





        //      FUNCIONES DE MONEY-MACHINE    //
        public static double PesosToDolares(double pesos)
        // funcion que convierte de pesos dominicanos a dólares estadounidenses
        {
            return pesos * 0.018;
        }

        public static double PesosToEuros(double pesos)
        {
            // funcion de convertir de pesos dominicanos a euros  
            return pesos * 0.017;
        }
        public static double DollarToPeso(double dollar)
        // funcion que convierte de dollar a dominican Bucks.
        {
            return dollar * 55.01;
        }

        public static double DollarToEuro(double dollar)
        // funcion que convierte de dollar a dominican Bucks.
        {
            return dollar * 0.9172;
        }

        public static double EuroToPeso(double Euro)
        // funcion que convierte de dollar a dominican Bucks.
        {
            return Euro * 60.04;
        }

        public static double EuroToDollar(double Euro)
        // funcion que convierte de dollar a dominican Bucks.
        {
            return Euro * 1.0903;
        }
        //##############################################################//


        public static void CALCULADORA()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(@"
                ________________ ______ ______________  ________ _______ _______________ ________ 
                __  ____/___    |___  / __  ____/__  / / /___  / ___    |___  __/__  __ \___  __ \
                _  /     __  /| |__  /  _  /     _  / / / __  /  __  /| |__  /   _  / / /__  /_/ /
                / /___   _  ___ |_  /___/ /___   / /_/ /  _  /____  ___ |_  /    / /_/ / _  _, _/ 
                \____/   /_/  |_|/_____/\____/   \____/   /_____//_/  |_|/_/     \____/  /_/ |_|  
                                                                                    
                                            [PRESS ENTER TO START]
                
                ");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(@"
                        QUE DESEA HACER?
                        ----------------
                    [1]     SUMAR.
                    [2]     RESTAR.
                    [3]     MULTIPLICAR.
                    [4]     DIVIDIR.
                    [5]     REGRESAR.
                
                ");
                opcion = Convert.ToInt32(Console.ReadLine()!);
                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("SUMANDO:");
                            Console.WriteLine("========\n");

                            Console.WriteLine("INTTRODUZCA EL PRIMER NUMERO: ");
                            double num1 = Convert.ToDouble(Console.ReadLine()!);
                            Console.WriteLine("INTRODUZCA EL SEGUNDO NUMERO: ");
                            double num2 = Convert.ToDouble(Console.ReadLine()!);
                            Console.WriteLine($"{num1} + {num2} = {SUMAR(num1, num2)}");
                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("RESTANDO:");
                            Console.WriteLine("=========\n");

                            Console.WriteLine("INTTRODUZCA EL PRIMER NUMERO: ");
                            double num1 = Convert.ToDouble(Console.ReadLine()!);
                            Console.WriteLine("INTRODUZCA EL SEGUNDO NUMERO: ");
                            double num2 = Convert.ToDouble(Console.ReadLine()!);
                            Console.WriteLine($"{num1} - {num2} = {RESTAR(num1, num2)}");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("MULTIPLICAR:");
                            Console.WriteLine("============\n");

                            Console.WriteLine("INTTRODUZCA EL PRIMER NUMERO: ");
                            double num1 = Convert.ToDouble(Console.ReadLine()!);
                            Console.WriteLine("INTRODUZCA EL SEGUNDO NUMERO: ");
                            double num2 = Convert.ToDouble(Console.ReadLine()!);
                            Console.WriteLine($"{num1} * {num2} = {MULTIPLICAR(num1, num2)}");
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("DIVIDIENDO:");
                            Console.WriteLine("============\n");

                            Console.WriteLine("INTTRODUZCA EL PRIMER NUMERO: ");
                            double num1 = Convert.ToDouble(Console.ReadLine()!);
                            Console.WriteLine("INTRODUZCA EL SEGUNDO NUMERO: ");
                            double num2 = Convert.ToDouble(Console.ReadLine()!);
                            Console.WriteLine($"{num1} / {num2} = {DIVIDIR(num1, num2)}");
                            Console.ReadKey();
                        }
                        break;

                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("CERRANDO APP...");
                            Thread.Sleep(3000);
                        }
                        break;

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("OPCION INVALIDA!");
                            Thread.Sleep(3000);
                        }
                        break;
                }

            } while (opcion != 5);

            MenuPrincipal();
        }

        // #===========FUNCIONES DE CALCULADOR===============#
        public static double SUMAR(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double RESTAR(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double MULTIPLICAR(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double DIVIDIR(double num1, double num2)
        {
            return num1 / num2;
        }

        //##############################################################//
    }

}