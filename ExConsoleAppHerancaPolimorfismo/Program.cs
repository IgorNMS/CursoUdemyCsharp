using System;
using System.Collections.Generic;
using System.Globalization;
using ExConsoleAppHerancaPolimorfismo.Entities;

namespace ExConsoleAppHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            
            List<Employee> listEmployees = new List<Employee>();
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                /*
                 * Polimorfismo
                 *
                 * E um recurso que permite que variaveis de mesmo tipo generico possam apontar para objetos
                 * de tipos especificos diferentes, tendo assim comportamentos diferentes conforme cada tipo
                 * especifico
                 */
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    listEmployees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    listEmployees.Add(new Employee(name, hours, valuePerHour));
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in listEmployees)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}