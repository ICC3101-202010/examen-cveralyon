﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN
{
    class Equipo
    {
        private List<Jugador> jugadores_equipo = new List<Jugador>();
        private string name;
        private Entrenador entrenador;
        private Medico medico;
        bool eq_nacional;
        bool eq_liga;
        string pais;

        public Equipo( string name, Entrenador entrenador, Medico medico,string pais,  bool eq_nacional, bool eq_liga)
        {
            this.name = name;
            this.entrenador = entrenador;
            this.medico = medico;
            this.eq_nacional = eq_nacional;
            this.eq_liga = eq_liga;
            this.pais = pais;
        }

        public string Name { get => name; set => name = value; }
        public bool Eq_nacional { get => eq_nacional; set => eq_nacional = value; }
        public bool Eq_liga { get => eq_liga; set => eq_liga = value; }
        public string Pais { get => pais; set => pais = value; }
        internal List<Jugador> Jugadores_equipo { get => jugadores_equipo; set => jugadores_equipo = value; }
        internal Entrenador Entrenador { get => entrenador; set => entrenador = value; }
        internal Medico Medico { get => medico; set => medico = value; }

        public void agregar_jugadores()
        {
            int num = jugadores_equipo.Count();
            while (num < 15)
            {
                string op3 = Program.ShowOptions(Jugador.nombre_jugadores());
                if (num < 15)
                {
                    foreach (Jugador en in Program.jugadores)
                    {
                        if (op3 == en.Name)
                        {
                            if ((en.Nacion.ToLower() == pais && eq_nacional == true) || eq_liga == true)
                            {
                                jugadores_equipo.Add(en);
                            }
                            else
                            {
                                Console.WriteLine("Lo sentimos, todos losjugadores deben ser de la misma nacionalidad que el equipo. --> " + pais + "\n");
                            }
                            

                        }
                    }

                }
                else if (num >= 15)
                {
                    Console.WriteLine("Este equipo ya posee sus 15 Jugadores");
                }
               
                num++;
            }
           
        }
        
        
        
    }
}
