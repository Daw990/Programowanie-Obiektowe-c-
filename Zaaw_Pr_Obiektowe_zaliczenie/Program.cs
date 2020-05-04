using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaaw_Pr_Obiektowe_zaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
              
            Employees employees = new Employees();
            employees.addEmployee(EmployeesFactory.secondEmployee());
            employees.addEmployee(EmployeesFactory.firstEmployee());
            

            Console.WriteLine( employees[1].ToString());

            employees.deleteEmployeeByIndex(3);

            Console.WriteLine( employees["Gandalf", "Szary"]);

            employees.GetEmployeeByIndex(0).addBonus = 700;

            Console.WriteLine(+employees.GetEmployeeByIndex(0));

            bool biggestReward = employees.GetEmployeeByIndex(0).reward > employees.GetEmployeeByIndex(1).reward;

            Console.WriteLine(biggestReward);

            employees.GetEmployeeByIndex(0).changeName("jan", "niezbedny", employees.GetEmployeeByIndex(0).zmiana);
            Console.WriteLine(employees.GetEmployeeByIndex(0).firstName +" "+ employees.GetEmployeeByIndex(0).lastName);

            employees.deleteEmployeeByIndex(3);
            employees.deleteEmployeeByIndex(1);

          Console.ReadKey();
        }
    }
}
