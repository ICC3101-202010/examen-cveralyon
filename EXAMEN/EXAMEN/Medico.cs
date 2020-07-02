using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN
{
    class Medico : Persona
    {
        private int ptos_xp;

        public Medico(string name, int age, int sueldo, string nacion, string tipo, int ptos_xp)
        {
            this.Name = name;
            this.Age = age;
            this.Sueldo = sueldo;
            this.Nacion = nacion;
            this.Tipo = tipo;
            this.ptos_xp = ptos_xp;

        }
        public int Ptos_xp { get => ptos_xp; set => ptos_xp = value; }

        public static void Crear_medico()
        {
            Console.WriteLine("Ingrese los datos del MEDICO:\n\n");
            Console.WriteLine("NOMBRE:");
            string n = Console.ReadLine();
            Console.WriteLine("\nEDAD:");
            int edad = Program.Numero(100);
            Console.WriteLine("\nSUELDO:");
            int s = Program.Numero(99999999);
            Console.WriteLine("\nNACIONALIDAD:");
            string nac = Console.ReadLine();
            Console.WriteLine("\nPUNTOS DE EXPERIENCIA:");
            int ptd = Program.Numero(99999999);

            Medico medico = new Medico(n, edad, s, nac, "medico", ptd);
            Program.medicos.Add(medico);
        }
        public static List<String> nombre_medicos()
        {
            List<String> nombres = new List<string>();
            foreach (Medico medico in Program.medicos)
            {
                nombres.Add(medico.Name);
            }

            return nombres;
        }
    }
}
