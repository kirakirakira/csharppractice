using System;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BethanysPieShopHRM
{
    public enum EmployeeType
    {
        Sales,
        Manager,
        Research,
        StoreManager
    }

    enum StoreType
    {
        Pie = 10,
        Donut = 20,
        Cake = 30
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee bethany = new Employee(
                "Bethany",
                "Woody",
                "wb@gmail.com",
                new DateTime(1990, 1, 22),
                25.45);

            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.StopWorking();
            bethany.ReceiveWage();

            CalculateWage(340, EmployeeType.Sales, StoreType.Pie);

            Console.ReadLine();
        }

        private static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType)
        {
            int calculateWage = 0;

            if (employeeType == EmployeeType.Manager)
            {
                calculateWage = baseWage * 3;
            }
            else
            {
                calculateWage *= 2;
            }

            if (storeType == StoreType.Pie)
            {
                calculateWage += 500;
            }

            Console.WriteLine($"The calculated wage is {calculateWage}");
        }

    }
}
