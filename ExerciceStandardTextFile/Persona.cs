using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceStandardTextFile
{
    class Persona
    {
        public Persona()
        {
        }

        public Persona(string firstName, string lastName, int age, bool alive)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Alive = alive;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public Boolean Alive { get; set; }
    }
}
