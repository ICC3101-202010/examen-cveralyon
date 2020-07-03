using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXAMEN
{
    class Program
    {
        public static List<Medico> medicos = new List<Medico>();
        public static List<Jugador> jugadores = new List<Jugador>();
        public static List<Entrenador> entrenadores = new List<Entrenador>();
        public static List<Equipo> equipos = new List<Equipo>();

        static void Main(string[] args)
        {

            Jugador jugador = new Jugador("jugador1", 23, 600, "chileno", "Jugador", 30, 20, false, 0);
            Jugador jugador1 = new Jugador("jugador2", 20, 650, "chileno", "Jugador", 30, 20, false, 1);
            Jugador jugador2 = new Jugador("jugador3", 25, 660, "chileno", "Jugador", 30, 20, false, 2);
            Jugador jugador3 = new Jugador("jugador4", 26, 640, "chileno", "Jugador", 30, 20, false, 3);
            Jugador jugador4 = new Jugador("jugador5", 23, 600, "chileno", "Jugador", 30, 20, false, 4);
            Jugador jugador5 = new Jugador("jugador6", 22, 650, "chileno", "Jugador", 30, 20, false, 5);
            Jugador jugador6 = new Jugador("jugador7", 22, 900, "chileno", "Jugador", 30, 20, false, 6);
            Jugador jugador7 = new Jugador("jugador8", 21, 800, "chileno", "Jugador", 30, 20, false, 7);
            Jugador jugador8 = new Jugador("jugador9", 20, 400, "chileno", "Jugador", 30, 20, false, 8);
            Jugador jugador9 = new Jugador("jugador10", 26, 660, "chileno", "Jugador", 30, 20, false, 9);
            Jugador jugador10 = new Jugador("jugador11", 27, 700, "chileno", "Jugador", 30, 20, false, 10);
            Jugador jugador11 = new Jugador("jugador12", 29, 800, "chileno", "Jugador", 30, 20, false, 11);
            Jugador jugador12 = new Jugador("jugador13", 25, 700, "chileno", "Jugador", 30, 20, false, 12);
            Jugador jugador13 = new Jugador("jugador14", 24, 800, "chileno", "Jugador", 30, 20, false, 13);
            Jugador jugador14 = new Jugador("jugador15", 23, 900, "chileno", "Jugador", 30, 20, true, 14);
            Jugador jugador0 = new Jugador("jugador0", 23, 600, "argentino", "Jugador", 30, 20, false, 15);
            Jugador jugador00 = new Jugador("jugador21", 20, 650, "argentino", "Jugador", 30, 20, false, 16);
            Jugador jugador21 = new Jugador("jugador31", 25, 660, "argentino", "Jugador", 30, 20, false, 25);
            Jugador jugador31 = new Jugador("jugador41", 26, 640, "argentino", "Jugador", 30, 20, false, 33);
            Jugador jugador41 = new Jugador("jugador51", 23, 600, "argentino", "Jugador", 30, 20, false, 44);
            Jugador jugador51 = new Jugador("jugador61", 22, 650, "argentino", "Jugador", 30, 20, false, 55);
            Jugador jugador61 = new Jugador("jugador71", 22, 900, "argentino", "Jugador", 30, 20, false, 63);
            Jugador jugador71 = new Jugador("jugador81", 21, 800, "argentino", "Jugador", 30, 20, false, 74);
            Jugador jugador81 = new Jugador("jugador91", 20, 400, "argentino", "Jugador", 30, 20, false, 85);
            Jugador jugador91 = new Jugador("jugador101", 26, 660, "argentino", "Jugador", 30, 20, false, 92);
            Jugador jugador101 = new Jugador("jugador111", 27, 700, "argentino", "Jugador", 30, 20, false, 21);
            Jugador jugador111 = new Jugador("jugador121", 29, 800, "argentino", "Jugador", 30, 20, false, 53);
            Jugador jugador121 = new Jugador("jugador131", 25, 700, "argentino", "Jugador", 30, 20, false, 54);
            Jugador jugador131 = new Jugador("jugador141", 24, 800, "argentino", "Jugador", 30, 20, false, 47);
            Jugador jugador141 = new Jugador("jugador151", 23, 900, "argentino", "Jugador", 30, 20, true, 46);
            List<Jugador> jjjk = new List<Jugador> { jugador0, jugador21, jugador101, jugador00, jugador111, jugador121, jugador131, jugador141, jugador21, jugador31, jugador41, jugador51, jugador61, jugador71, jugador81, jugador91 };
            foreach (Jugador j in jjjk)
            {
                jugadores.Add(j);
            }
            List<Jugador> jjk = new List<Jugador> { jugador, jugador2, jugador1, jugador10, jugador11, jugador12, jugador13, jugador14, jugador2, jugador3, jugador4, jugador5, jugador6, jugador7, jugador8, jugador9 };
            foreach (Jugador j in jjk)
            {
                jugadores.Add(j);
            }
            Medico medico1 = new Medico("medico1", 55, 562, "venezolano", "Medico", 100);
            Medico medico2 = new Medico("medico2", 45, 562, "argentino", "Medico", 200);
            Medico medico3 = new Medico("medico3", 65, 562, "chileno", "Medico", 50);
            Medico medico4 = new Medico("medico4", 57, 562, "peruano", "Medico", 300);
            Medico medico5 = new Medico("medico5", 53, 562, "uruguayo", "Medico", 250);
            medicos.Add(medico1); medicos.Add(medico2); medicos.Add(medico3); medicos.Add(medico4);medicos.Add( medico5);
            Entrenador entrenador1 = new Entrenador("entrenador1", 53, 10000, "argentino", "Entrenador", 100);
            Entrenador entrenador2 = new Entrenador("entrenador2", 63, 10000, "argentino", "Entrenador", 200);
            Entrenador entrenador3 = new Entrenador("entrenador3", 59, 10000, "argentino", "Entrenador", 300);
            Entrenador entrenador4 = new Entrenador("entrenador4", 49, 10000, "argentino", "Entrenador", 150);
            Entrenador entrenador5 = new Entrenador("entrenador5", 35, 10000, "argentino", "Entrenador", 500);
            entrenadores.Add(entrenador1); entrenadores.Add(entrenador2); entrenadores.Add(entrenador3); entrenadores.Add(entrenador4); entrenadores.Add(entrenador5);
            Console.WriteLine("\tBIENVENIDO AL PROGRAMA DE EXAMEN DE CRISTIAN VERA\n\n" +
                ">>(EN ESTE PROGRAMA NO PODRAS JUGAR SOLO CREAR TUS EQUIPOS)<<\n\n\n");

            Console.WriteLine("\n\n\t\t======AVISO===USE LA PANTALLA COMPLETA DE SU CONSOLA ===============\n\n\n\n");


            Console.WriteLine("\t\t========================");

            int accion = '\0';
            int accion2 = '\0';
            int accion3 = '\0';
            while (accion != 4)
            {
                Console.WriteLine("Seleccione una opción: \n");
                Console.WriteLine("1. PRUEBA AUTOMATICA DEL PROGRAMA \n");
                Console.WriteLine("2. AGREGAR JUGADORES-ENTRENADORES-MEDICOS A LA BASE DE DATOS\n");
                Console.WriteLine("3. CREAR UN EQUIPO\n");
                Console.WriteLine("4. CERRAR PROGRAMA (NO GUARDA LOS DATOS)\n");
                accion = Numero(4);
                switch (accion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\t\t================CREANDO JUGADORES===============\n\n");
                        Thread.Sleep(2000);
                        Console.WriteLine("\t\t==========CREANDO MEDICOS Y ENTRENADORES===========\n\n");
                        Thread.Sleep(2000);
                        Console.WriteLine("\t\t===============CREANDO TUS EQUIPOS=================\n\n");
                        Thread.Sleep(2000);
                        Console.WriteLine("\t\t====================================================\n");

                        List<Jugador> jjj = new List<Jugador> { jugador0, jugador21, jugador101, jugador00, jugador111, jugador121, jugador131, jugador141, jugador21, jugador31, jugador41, jugador51, jugador61, jugador71, jugador81, jugador91 };
                        Equipo equipo2 = new Equipo("equipo2", entrenador3, medico2, "argentino", true, false);
                        foreach (Jugador j in jjj)
                        {
                            equipo2.Jugadores_equipo.Add(j);
                        }
                        List<Jugador> jj = new List<Jugador> { jugador, jugador2, jugador1, jugador10, jugador11, jugador12, jugador13, jugador14, jugador2, jugador3, jugador4, jugador5, jugador6, jugador7, jugador8, jugador9 };
                        Equipo equipo1 = new Equipo("equipo1", entrenador1, medico1, "chileno", true, false);
                        foreach(Jugador j in jj)
                        {
                            equipo1.Jugadores_equipo.Add(j);
                        }
                        Console.Clear();
                        Console.WriteLine("\t===============TODO LISTO SE HAN CREADO 2 EQUIPOS LOS VERAN EN PANTALLA PRONTO=================\n\n");
                        Thread.Sleep(5000);
                        Console.Clear();
                        Console.WriteLine("\t\t\t   ====================================================\n");

                        Console.WriteLine("\n\t\t\t\t===============EQUIPO 1=================\n");
                        Console.WriteLine("====================================================\n");
                        Console.WriteLine(" NOMBRE:"+equipo1.Name+" \n");
                        equipo1.Entrenador.verInfo_Persona();
                        Console.WriteLine("\n");
                        equipo1.Medico.verInfo_Persona();
                        Console.WriteLine("\n TIPO DE EQUIPO: NACIONAL \n");
                        foreach (Jugador ju in equipo1.Jugadores_equipo)
                        {
                            Console.WriteLine("====================================================\n");
                            ju.verInfo_Persona();
                            Console.WriteLine(">DEFENSA: " + ju.Ptos_defensa + " >ATAQUE: " + ju.Ptos_ataque + " >CAMISETA: " + ju.N_camiseta + " >ARQUERO: " + ju.Arquero.ToString());
                        }
                        Thread.Sleep(3000);
                        Console.WriteLine("\t\t\t   ====================================================\n");

                        Console.WriteLine("\t\t\t\t===============EQUIPO 2=================\n");
                        Console.WriteLine("====================================================\n");

                        Console.WriteLine(" NOMBRE:" + equipo2.Name + " \n");
                        equipo2.Entrenador.verInfo_Persona();
                        Console.WriteLine("\n");
                        equipo2.Medico.verInfo_Persona();
                        Console.WriteLine("\n TIPO DE EQUIPO: NACIONAL \n");
                        foreach (Jugador ju in equipo2.Jugadores_equipo)
                        {
                            Console.WriteLine("====================================================\n");
                            ju.verInfo_Persona();
                            Console.WriteLine(">DEFENSA: " + ju.Ptos_defensa + " >ATAQUE: " + ju.Ptos_ataque + " >CAMISETA: " + ju.N_camiseta + " >ARQUERO: " + ju.Arquero.ToString());
                        }
                        Console.WriteLine("====================================================\n");
                        Console.WriteLine("====================================================\n");
                        Console.WriteLine("====================================================\n\n\n");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Seleccione una opción: \n");
                        Console.WriteLine("1. AGREGAR JUGADOR \n");
                        Console.WriteLine("2. AGREGAR ENTRENADOR\n");
                        Console.WriteLine("3. AGREGAR MEDICO\n");
                        Console.WriteLine("4. ATRAS\n");
                        accion2 = Numero(4);
                        switch (accion2)
                        {
                            case 1:
                                Jugador.Crear_jugador();
                                Console.WriteLine("\n>>>JUGADOR CREADO EXITOSAMENTE<<<\n\n");
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            case 2:
                                Entrenador.Crear_entrenador();
                                Console.WriteLine("\n>>>ENTRENADOR CREADO EXITOSAMENTE<<<\n\n");
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            case 3:
                                Medico.Crear_medico();
                                Console.WriteLine("\n>>>MEDICO CREADO EXITOSAMENTE<<<\n\n");
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            case 4:
                                break;

                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(" QUE TIPO DE EQUIPO DESEA CREAR:\n" +
                            "1. NACIONAL\n" +
                            "2. LIGA\n");
                        accion3 = Numero(2);
                        bool nac = false;
                        bool liga = false;
                        if (accion3 == 1)
                        {
                            nac = true;
                        }else if(accion3==2) {
                            liga = true;
                        }
                        Console.WriteLine("INGRESE EL NOMBRE DEL EQUIPO: ");
                        string nombequipo = Console.ReadLine();
                        Console.WriteLine("INGRESE LA NACIONALIDAD DEL EQUIPO: ");
                        string nacequipo = Console.ReadLine();
                        Console.WriteLine("ESCOJA UN MEDICO PARA EL EQUIPO: ");
                        string op = ShowOptions(Medico.nombre_medicos());
                        Medico nopmbmed=null;
                        foreach(Medico med in medicos)
                        {
                            if (op == med.Name)
                            {
                                nopmbmed = med;
                            }
                        }
                        Console.WriteLine("ESCOJA UN ENTRENADOR PARA EL EQUIPO: ");
                        string op2 = ShowOptions(Entrenador.nombre_entrenadores());
                        Entrenador nombentre=null;
                        foreach (Entrenador en in entrenadores)
                        {
                            if (op2 == en.Name)
                            {
                                nombentre = en;
                            }
                        }
                        Equipo equipo = new Equipo(nombequipo, nombentre, nopmbmed, nacequipo, nac, liga);

                        Console.WriteLine("ESCOJA 15 jugadores PARA EL EQUIPO: ");                        
                        equipo.agregar_jugadores();
                        break;
                }
            }
        }
        public static int Numero(int o) // verifica que el input  sea un numero dentro del rango requerido
        {
            int n;
            bool aux0;
            do
            {
                string p;
                p = Console.ReadLine();
                aux0 = int.TryParse(p, out n);
                if (aux0 == false || n > o) { Console.WriteLine("---ERROR: INGRESE SOLO NUMEROS del 1 al {0}---", o); }
            } while (!aux0 || n > o);

            return n;
        }

        public static string ShowOptions(List<string> options)
        {
            int i = 0;
            Console.WriteLine("\n\nSelecciona una opcion:");
            foreach (string option in options)
            {
                Console.WriteLine(Convert.ToString(i) + ". " + option);
                i += 1;
            }
            return options[Convert.ToInt16(Console.ReadLine())];
        }

    }
}
