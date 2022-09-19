using ExercPayPolimorfi.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercPayPolimorf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numEmp = int.Parse(Console.ReadLine());
            List<Employee> lstEmp = new List<Employee>();

            for(int i = 1; i <= numEmp; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write($"Outsourced (y / n)? ");
                char outsourced = Char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Value per Hours: ");
                double valuePerH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'n')
                    lstEmp.Add(new Employee(name, hours, valuePerH));
                else
                {
                    Console.Write("Additional charge: ");
                    double aditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lstEmp.Add(new OutsourcedEmployee(name, hours, valuePerH, aditionalCharge));
                }                
            }
            Console.WriteLine();
            Console.Write("PAYMENTS: ");
            foreach(Employee emp in lstEmp)
            {
                Console.WriteLine(emp.ToString());
            }

            Console.ReadLine();
        }
    }
}
