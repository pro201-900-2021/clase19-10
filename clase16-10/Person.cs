using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase16_10
{
    class Person
    {
        private string name;
        private string lastName;
        private string id;
        private int age;

        public Person() { }

        public Person(string name, string lastName, string id, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.id = id;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }

        //primer elemento: 0
        //último elemento: largo-1
        public void showInfo()
        {
            string info = "Hola! Me llamo "+name+", tengo "+age+" años y mi apellido es "+lastName+"."; //concatenar
            string info2 = $"Hola! Me llamo {name}, tengo {age} años y mi apellido es {lastName}."; //cadenas mixtas
            string info3 = String.Format("Hola! Me llamo {0}, tengo {1} años y mi apellido es {2}.", name, age, lastName); //indicador
            Console.WriteLine(info);
            Console.WriteLine(info2);
            Console.WriteLine(info3);
            Console.WriteLine("Hola! Me llamo {0}, tengo {1} años y mi apellido es {2}.", name, age, lastName);
        }
    }
}
