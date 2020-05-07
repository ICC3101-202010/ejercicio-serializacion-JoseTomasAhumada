using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace Ejemplo_Realizacion
{
    [Serializable]
    class Persona : Stream, IFormatter
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
        public static void SavePersons(List<Persona> listperson)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, listperson);
            stream.Close();
        }
        public static void LoadPersons()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Persona person = (Persona)formatter.Deserialize(stream);
            stream.Close();
        }
    }
}
