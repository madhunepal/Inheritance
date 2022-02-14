using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUniversity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiates Employee object 
            var employee1 = new Employee("Madhu", 2500);

            //instantiates tech employee 
            var employee2 = new TechEmployee("Shanti ");

            //instantiates business employee 
            var employee3 = new BusinessEmployee("Ram");


            Console.WriteLine( employee1.EmployeeStatus() + " ..." 
                + employee2.EmployeeStatus() + "..." + employee3.EmployeeStatus());
            Console.ReadLine();

        }
    }
}
