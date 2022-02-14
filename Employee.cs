using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUniversity
{
    abstract class Employee
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public int ID { get; set; }
        // Creates integer variable called "employeeCount" and assigns value to 1
        private static int employeeCount = 1;
        //this.ID = employeeCount++;
        public Employee(string name, double baseSalary)
        {
            this.BaseSalary = baseSalary;
            this.Name = name;
            this.ID = employeeCount++;
        }
        public double GetBaseSalary()
        {
            return this.BaseSalary;
        }
        // This method returns the employee's name
        public String getName()
        {
            return this.Name;
        }
        public int GetEmployeeId()
        {
            return this.ID;
        }
        public string ToString()
        {
            return this.ID + " " + this.Name;
        }
        public abstract String EmployeeStatus();
        //{
        //    return ToString() + " is in the company's system";
        //}
    }
}
