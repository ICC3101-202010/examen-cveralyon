using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN
{
    public abstract class Persona
    {
        private string name;
        private int age;
        private int sueldo;
        private string nacion;
        private string tipo;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }
        public string Nacion { get => nacion; set => nacion = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        
        public  void verInfo_Persona() 
        {
            Console.WriteLine(" Informacion del " + tipo + ":\n" +
                "NOMBRE: "+name+"\n" +
                "EDAD: "+age+"\n" +
                "NACIONALIDAD: "+nacion+"\n" +
                "SUELDO: $"+sueldo+" Dolares/Mes");
        }


    }
}
