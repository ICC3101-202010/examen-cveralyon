using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN
{
    class Partido
    {
        private string nombredelencuentro;
        private Equipo equipo_1;
        private Equipo equipo_2;
        private bool liga = false; // por defencto se asumen los partidos como nacionales a menos que se especifique lo contrario
        private string resultado; // aqui va el equipo ganador y por cuanto
        private int goles_eq1;
        private int goles_eq2;
        private int tiempo = 90;

        public Partido(string nombredelencuentro, Equipo equipo_1, Equipo equipo_2, bool liga)
        {
            this.nombredelencuentro = nombredelencuentro;
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
        public int Tiempo { get => tiempo; set => tiempo = value; }
        public string Nombredelencuentro { get => nombredelencuentro; set => nombredelencuentro = value; }

        public void jugar()
        {
           // se hace un while con un thead para que cada partido se tome 5 min aprox en los que el while va recorriendo 
           // con un random de 1 a 50 es para ver la posibilidad de que un jugador se lecione
           // con otro random se ve que jugador se lecionara
           // al lecionarse un jugador un if(jugador lecionado) 
           //gatilla el evento que avisa al entrenador
           // el entrenador al recivir este evento gatilla otro paara avisar al partido
           //el´partido suma tiempo extra o de descuento y se hace un cambio de jugador

        }
        public void definicion_goles()
        {
            // se hace un random entre 1 a 10 para los goles de el equipo 1 
            // luego un random de 1 a 10 para los goles de equipo 2 
        }
        public void evaluar_ganador()
        { 
            // se evalua que equipo tiene mas goles

        }
    }
}
