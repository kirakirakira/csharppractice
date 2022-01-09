using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.HR;
using System;
using System.Collections.Generic;

namespace BethanysPieShopHRM
{
    class Program
    {
        public static List<Employee> employees = new List<Employee>();

        public static void DisplayAllEmployees()
        {
            foreach (Employee employee in employees)
            {
                employee.DisplayEmployeeDetails();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------\n");

            //Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), EmployeeType.Manager, 25);
            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), EmployeeType.Manager, null);
            Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), EmployeeType.Research, 30);

            employees.Add(bethany);
            employees.Add(george);

            //Employee mysteryPerson = null;
            //mysteryPerson.DisplayEmployeeDetails();

            Customer customer = new Customer();

            #region First run Bethany

            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();
            bethany.DisplayEmployeeDetails();

            #endregion


            #region First run George

            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.ReceiveWage();
            george.DisplayEmployeeDetails();

            #endregion

            Employee.taxRate = 0.05;//woohoo, less money to pay
            #region Second run Bethany

            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();
            bethany.DisplayEmployeeDetails();

            #endregion

            #region Second run George

            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.ReceiveWage();
            george.DisplayEmployeeDetails();

            #endregion


            Employee.DisplayTaxRate();

            Console.WriteLine("===========");
            DisplayAllEmployees();
            List<Employee> employees2 = new List<Employee>();
            for (int i = 0; i < 10000000; i++)
            {
                Employee randomEmployee = new Employee(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), new DateTime(1979, 1, 16), EmployeeType.StoreManager, null);
                employees2.Add(randomEmployee);
            }

            employees2.Clear();
            employees2 = null;

            // GC.Collect();

            Console.ReadLine();
        }
    }
}
