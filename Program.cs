using Principal.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Principal {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of the employees: ");
            int employeesQty = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= employeesQty; i++) 
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char employeeOutsourced = char.Parse(Console.ReadLine());
                if(employeeOutsourced == 'y' || employeeOutsourced == 'Y') {
                    Console.Write("Name: ");
                    string employeeName = Console.ReadLine();
                    Console.Write("Hours: ");
                    int employeeHours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double employeeValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Additional charge: ");
                    double employeeAdditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutsourcedEmployee(employeeName, employeeHours, employeeValuePerHour, employeeAdditionalCharge));
                    
                }

                else {
                    Console.Write("Name: ");
                    string employeeName = Console.ReadLine();
                    Console.Write("Hours: ");
                    int employeeHours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double employeeValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new Employee(employeeName, employeeHours, employeeValuePerHour));
                }
            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in employees) 
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}