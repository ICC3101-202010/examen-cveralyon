using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN
{
    class Entrenador: Persona
    {
        int ptos_tactica;
        public Entrenador(string name, int age, int sueldo, string nacion, string tipo, int ptos_tactica)
        {
            this.Name = name;
            this.Age = age;
            this.Sueldo = sueldo;
            this.Nacion = nacion;
            this.Tipo = tipo;
            this.ptos_tactica = ptos_tactica;

        }

        public int Ptos_tactica { get => ptos_tactica; set => ptos_tactica = value; }

        public static void Crear_entrenador()
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
            Console.WriteLine("\nPUNTOS DE TACTICA:");
            int ptd = Program.Numero(99999999);

            Entrenador entrenador = new Entrenador(n, edad, s, nac, "Entrenador", ptd);
            Program.entrenadores.Add(entrenador);
        }
        public static List<String> nombre_entrenadores()
        {
            List<String> nombres = new List<string>();
            foreach (Entrenador entrenador in Program.entrenadores)
            {
                nombres.Add(entrenador.Name);
            }

            return nombres;
        }
    }
}
