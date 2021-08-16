using System;

    namespace EstructurasdeControl
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                principal();
            }

        static void principal()
        {
            int repMEnu;

            Console.WriteLine("                                                                             ");
            Console.WriteLine("=============================================================================");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("                 Estructuras de control en Visual C#                         ");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("                 1. Menú                                                     ");
            Console.WriteLine("                 2. Salir                                                    ");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("                 Ingrese 1 para mostrar menú o 2 para salir.                 ");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("=============================================================================");
            Console.WriteLine("                                                                             ");
            var cprompt = "\t\t\t\t\t\t   Opcion:";
            Console.Write(string.Format("{0," + ((Console.WindowWidth / 1) + (cprompt.Length / 1)) + "}", cprompt));
            repMEnu = Int32.Parse(Console.ReadLine());            
            if (repMEnu ==1) {
                while (repMEnu == 1)
                {
                    Console.Clear();
                    opciones();
                }
            }
            else if (repMEnu ==2)
            {
                Environment.Exit(2);
            }
            else
            {
                Console.WriteLine("La opcion seleccionada no es valida");
            }
            }
            static void opciones(){
            Console.Clear();
            int opcion,repMenu;
                Console.WriteLine("                                                                             ");
                Console.WriteLine("=============================================================================");
                Console.WriteLine("                                                                             ");
                Console.WriteLine("                 Pequeño menu de estructura de control                       ");
                Console.WriteLine("                                                                             ");
                Console.WriteLine("                 1-- Integrantes del Equipo                                  ");
                Console.WriteLine("                 2-- Carnet de los Integrantes                               ");
                Console.WriteLine("                 3-- Nombre del Maestro                                      ");
                Console.WriteLine("                 4-- Nombre de la Asignatura                                 ");
                Console.WriteLine("                                                                             ");
                Console.WriteLine("=============================================================================");
                Console.WriteLine("                                                                             ");
            var cprompt = "   Elije una Opcion para visualizar:";
            Console.Write(string.Format("{0," + (  (cprompt.Length / 1)) + "}", cprompt));
            opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        programa1();
                        break;

                    case 2:
                        Console.Clear();
                        programa2();
                        break;

                    case 3:
                        Console.Clear();
                        programa3();
                        break;

                    case 4:
                        Console.Clear();
                        programa4();
                        break;
                    default:
                        System.Console.WriteLine("La opción que a seleccionado es incorrecta");
                        break;
                }
            Console.WriteLine("Presiona 1 para seguir o 2 para salir");
             repMenu=Int32.Parse(Console.ReadLine());
            if (repMenu == 1){

                Console.Clear();
                opciones();

            }
            else if(repMenu == 2){

                Console.Clear();
                Environment.Exit(2);

            }
            else{

                Console.WriteLine("La opcion seleccionada no es valida");

            }
                static void programa1(){
         System.Console.WriteLine("                                                                             ");
                Console.WriteLine("                 Integrantes                                                 ");
                Console.WriteLine("                                                                             ");
                Console.WriteLine("                 1 - Alan Derek Henríquez Monterrosa.                        ");
                Console.WriteLine("                 2 - Karla Daniela Torres Esperanza.                         ");
                Console.WriteLine("                 3 - Josselyn Edith Rivas Garay.                             ");
                Console.WriteLine("                 4 - Ivania Melani Campos Gómez.                             ");
                Console.WriteLine("                 5 - Geovanni Alexander Guerrero Munguía.                    ");
                Console.WriteLine("                 6 - Álvaro Antonio Rivera Moran.                            ");
                Console.WriteLine("                                                                             ");
                Console.WriteLine("=============================================================================");
                Console.WriteLine("                                                                             ");
                }
                static void programa2()
                {
         System.Console.WriteLine("                                                                             ");
                Console.WriteLine("                 Numero de Carnet                                            ");
                Console.WriteLine("                                                                             ");
                Console.WriteLine("                 1 - USIS003421                                              ");
                Console.WriteLine("                 2 - USIS046821                                              ");
                Console.WriteLine("                 3 - USIS052421                                              ");
                Console.WriteLine("                 4 - USIS055421                                              ");
                Console.WriteLine("                 5 - USIS015221                                              ");
                Console.WriteLine("                 6 - USIS039521                                              ");
                Console.WriteLine("                                                                             ");
                Console.WriteLine("=============================================================================");
                Console.WriteLine("                                                                             ");
                }
                static void programa3()
                {
         System.Console.WriteLine("                                                                             ");
                Console.WriteLine("                 Maestro                                                     ");
                Console.WriteLine("                                                                             ");
                Console.WriteLine("                ' Ing. Pedro Antonio Villalta '                              ");
                Console.WriteLine("                                                                             ");
                Console.WriteLine("=============================================================================");
                Console.WriteLine("                                                                             ");
                }
                static void programa4()
                {
         System.Console.WriteLine("                                                                             ");
                Console.WriteLine("                 Asignatura                                                  ");
                Console.WriteLine("                                                                             ");
                Console.WriteLine("                ' Principios de Electrónica '                                  ");
                Console.WriteLine("                                                                             ");
                Console.WriteLine("=============================================================================");
                Console.WriteLine("                                                                             ");
                }
            }
        }
    }
 