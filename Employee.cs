using System;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BethanysPieShopHRM
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;
        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;
        public DateTime birthDay;

        public EmployeeType employeeType;
        public void PerformWork()
        {
            numberOfHoursWorked++;

            Console.WriteLine($"{firstName} {lastName} is now working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{firstName} {lastName} has stopped working!");
        }

        public double ReceiveWage()
        {
            wage = numberOfHoursWorked * hourlyRate;

            Console.WriteLine($"The wage for {numberOfHoursWorked} hours of work is {wage}.");
            numberOfHoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {firstName}\nLast name: {lastName}\nEmail: {email}\nBirthday: {birthDay.ToShortDateString()}\nEmployee type: {employeeType}\n");
        }
    }
}
