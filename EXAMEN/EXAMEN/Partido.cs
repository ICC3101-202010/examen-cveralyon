using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN
{
    class Partido
    {
        private Equipo equipo_1;
        private Equipo equipo_2;
        private bool liga = false; // por defencto se asumen los partidos como nacionales a menos que se especifique lo contrario
        private string resultado; // aqui va el equipo ganador y por cuanto
        private int goles_eq1;
        private int goles_eq2;

        public Partido(Equipo equipo_1, Equipo equipo_2, bool liga)
        {
            this.equipo_1 = equipo_1;
            this.equipo_2 = equipo_2;
            this.liga = liga;
        }

        public bool Liga { get => liga; set => liga = value; }
        public string Resultado { get => resultado; set => resultado = value; }
        public int Goles_eq1 { get => goles_eq1; set => goles_eq1 = value; }
        public int Goles_eq2 { get => goles_eq2; set => goles_eq2 = value; }
        internal Equipo Equipo_1 { get => equipo_1; set => equipo_1 = value; }
        internal Equipo Equipo_2 { get => equipo_2; set => equipo_2 = value; }
    }
}
