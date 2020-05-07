using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Realizacion
{
    class Persona
    {
        private string name;
        private string lastname;
        private int age;
        public Persona(string name, string lastname, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }
        public string Name()
        {
            return name;
        }
        public string Lastname()
        {
            return lastname;
        }
        public int Age()
        {
            return age;
        }
    }
}
