using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaaw_Pr_Obiektowe_zaliczenie
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return "imie: " + firstName + ", Nazwisko: " + lastName;
        }
    }
}
