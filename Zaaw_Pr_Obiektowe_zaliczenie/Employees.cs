using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaaw_Pr_Obiektowe_zaliczenie
{
    class Employees
    {
        List<Employee> employeesList = new List<Employee>();

        public Employee this[int index]
        {
            get
            {
                return employeesList[index];
            }
            set
            {
                employeesList[index] = value;
            }
        }

        public string this[string firstName, string lastName]
        {
            get
            {
                if(employeesList.Exists(x => x.firstName == firstName) && employeesList.Exists(x => x.lastName == lastName))
                {
                    return "Pracownik o podanym imieniu i nazwisku znajduje sie na liscie";
                }
                return "Pracownik nie został odnaleziony";
            }
        }
        public void addEmployee(Employee employee)
        {
                if (!employeesList.Contains(employee))
                {
                    employeesList.Add(employee);
                }
                else
                {
                    Console.WriteLine("Podany pracownik juz istnieje");
                }           
        }
        public void deleteEmployeeByIndex(int index)
        {
            if(index > employeesList.Count - 1)
            {
                Console.WriteLine("podany index przekracza zakres listy");
            }
            else
            {
                employeesList.RemoveAt(index);
            }                          
        }
        public Employee GetEmployeeByIndex(int index)
        {
            return employeesList[index];
        }
    }
}
