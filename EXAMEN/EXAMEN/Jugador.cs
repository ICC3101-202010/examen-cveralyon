using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN
{
    class Jugador : Persona
    {
        int ptos_ataque;
        int ptos_defensa;
        bool arquero;
        int n_camiseta;
        public Jugador(string name, int age, int sueldo, string nacion, string tipo, int ptos_ataque, int ptos_defensa, bool arquero, int n_camiseta)
        {
            this.Name = name;
            this.Age = age;
            this.Sueldo = sueldo;
            this.Nacion = nacion;
            this.Tipo = tipo;
            this.ptos_ataque = ptos_ataque;
            this.ptos_defensa = ptos_defensa;
            this.arquero = arquero;
            this.n_camiseta = n_camiseta;
            
        }

        public int Ptos_ataque { get => ptos_ataque; set => ptos_ataque = value; }
        public int Ptos_defensa { get => ptos_defensa; set => ptos_defensa = value; }
        public bool Arquero { get => arquero; set => arquero = value; }
        public int N_camiseta { get => n_camiseta; set => n_camiseta = value; }

        public static  void Crear_jugador()
        {

            Console.WriteLine("Ingrese los datos del ENTRENADOR:\n\n");
            Console.WriteLine("NOMBRE:");
            string n = Console.ReadLine();
            Console.WriteLine("\nEDAD:");
            int edad = Program.Numero(110);
            Console.WriteLine("\nSUELDO:");
            int s = Program.Numero(99999999);
            Console.WriteLine("\nNACIONALIDAD:");
            string nac = Console.ReadLine();
            Console.WriteLine("\nPUNTOS DE ATAQUE:");
            int ptsataque = Program.Numero(99999999);
            Console.WriteLine("\nPUNTOS DE DEFENSA:");
            int ptsdefensa = Program.Numero(99999999);
            Console.WriteLine("\nNUMERO DE CAMISETA:");
            int camiseta = Program.Numero(99999999);
            Console.WriteLine("\nES ARQUERO\n" +
                "1-> SI\n" +
                "2-> NO\n" +
                ">");
            int nn = Program.Numero(2);
            bool arq=false;
            if (nn == 1)
            {
                arq = true;
            }else if (nn == 2)
            {
                arq = false;
            }


            Jugador jugador = new Jugador(n, edad, s, nac, "Jugador", ptsataque, ptsdefensa, arq, camiseta);
            Program.jugadores.Add(jugador);

        }


        public static List<String> nombre_jugadores()
        {
            List<String> nombres = new List<string>();
            foreach (Jugador jugador in Program.jugadores)
            {
                nombres.Add(jugador.Name);
            }

            return nombres;
        }
    }
}
