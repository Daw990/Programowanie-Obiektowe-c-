using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaaw_Pr_Obiektowe_zaliczenie
{
    class Employee : Person
    {

        public delegate void Delegacja(string s);

        public static void delegation(string msg)
        {

            Console.WriteLine(msg);
        }
        public Delegacja zmiana = delegation;

        List<Operation> operations = new List<Operation>();

        public int reward;
        public int addBonus  {get;set; } 
        enum Contract { FullTime, PartTime, Contract };
        public Employee(string firstName, string lastName, int reward) : base(firstName, lastName)
        {
            this.reward = reward;
        }

        public void changeName(string fName, string sName, Delegacja call)
        {
            firstName = fName;
            lastName = sName;
            zmiana("imie i nazwisko zostalo zmienione");
        } 

        public static int operator +(Employee employee)
        {       
            return employee.reward + employee.addBonus;
        }

        public static bool operator <(Employee employee1, Employee employee2)
        {
            if (employee1.reward < employee2.reward)
                return true;
            else
                return false;
        }
        public static bool operator >(Employee employee1, Employee employee2)
        {
            if (employee1.reward > employee2.reward)
                return true;
            else
                return false;
        }
        public Operation this[int index]   // indeksator
        {
            get
            {
                return operations[index];
            }
            set
            {
                operations[index] = value;
            }
        }

        public void newOperation() { }

        public void summaryOperations() { }

        public void getOperationsFromToDate (DateTime dateFrom, DateTime datetTo)
        {

        }

    }
}

