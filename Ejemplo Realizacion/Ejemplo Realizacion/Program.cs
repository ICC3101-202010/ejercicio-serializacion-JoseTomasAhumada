using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;

namespace Ejemplo_Realizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listperson = new List<Persona>();
            while (true)
            {
                Console.WriteLine("¿Qué desea hacer a continuación? [1]Crear Persona [2]Ver Personas [3]Cargar Personas [4]Guardar Personas [5]Salir");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("Nombre de la persona:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Apellido de la persona:");
                    string lastname = Console.ReadLine();
                    Console.WriteLine("Edad de la persona:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Persona person = new Persona(name, lastname, age);
                    listperson.Add(person);
                }
                if (option == "2")
                {
                    if (listperson.Count() == 0)
                    {
                        Console.WriteLine("ERROR, no hay personas registradas.");
                    }
                    else
                    {
                        Console.WriteLine("NOMBRE APELLIDO EDAD");
                        foreach (Persona person in listperson)
                        {
                            Console.WriteLine(person.Name() + " " + person.Lastname() + " " + person.Age());
                        }
                    }
                }
                if (option == "3")
                {
                    Persona.LoadPersons();
                }
                if (option == "4")
                {
                    Persona.SavePersons(listperson);
                }
                if (option == "5")
                {
                    break;
                }
            }
        }
    }
}
