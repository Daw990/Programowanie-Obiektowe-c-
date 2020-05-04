using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaaw_Pr_Obiektowe_zaliczenie
{
    class EmployeesFactory
    {
        public static Employee firstEmployee()
        {
            return new Employee("Gandalf", "Szary", 1000);
        }
        public static Employee secondEmployee()
        {
            return new Employee("Zygmunt", "Waza", 1500);
        }
    }
}
