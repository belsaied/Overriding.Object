using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Nu_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Testing Equals method.
            // Create some Person objects
            Person person1 = new Person { FirstName = "Belal", LastName = "Saied", Age = 20 };
            Person person2 = new Person { FirstName = "Hazem", LastName = "Yaser", Age = 20 };
            Person person3 = new Person { FirstName = "Belal", LastName = "Saied", Age = 20 };

            // Test equality
            Console.WriteLine(person1.Equals(person2)); // Output: False
            Console.WriteLine(person1.Equals(person3)); // Output: True

            // Test hash codes
            Console.WriteLine(person1.GetHashCode());
            Console.WriteLine(person3.GetHashCode()); // Should be the same as person1
            #endregion

            #region Testing ToString()
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();


            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());


            Person person = new Person { FirstName = firstName, LastName = lastName, Age = age };

            Console.WriteLine(person);
            #endregion


            #region Testing tryParse

            Console.Write("Enter the number of employees: ");
            int numEmployees;
            if (!int.TryParse(Console.ReadLine(), out numEmployees))
            {
                Console.WriteLine("Invalid number of employees.");
                return;
            }

            Emp[] employees = new Emp[numEmployees];

            for (int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine($"Enter details for employee {i + 1}:");

                Console.Write("ID: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid ID.");
                    continue;
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                if (!double.TryParse(Console.ReadLine(), out double salary))
                {
                    Console.WriteLine("Invalid salary.");
                    continue;
                }

                Console.Write("Employee type (FT for Full-time, PT for Part-time): ");
                string empType = Console.ReadLine().ToUpper();

                if (empType == "FT")
                {
                    Console.Write("Bonus: ");
                    if (!double.TryParse(Console.ReadLine(), out double bonus))
                    {
                        Console.WriteLine("Invalid bonus.");
                        continue;
                    }

                    Console.Write("Deduction: ");
                    if (!double.TryParse(Console.ReadLine(), out double deduction))
                    {
                        Console.WriteLine("Invalid deduction.");
                        continue;
                    }

                    employees[i] = new FT_Emp { Id = id, Name = name, Salary = salary, Bonus = bonus, Deduction = deduction };
                }
                else if (empType == "PT")
                {
                    Console.Write("Hours: ");
                    if (!int.TryParse(Console.ReadLine(), out int hours))
                    {
                        Console.WriteLine("Invalid hours.");
                        continue;
                    }

                    Console.Write("Rate per hour: ");
                    if (!double.TryParse(Console.ReadLine(), out double rateHour))
                    {
                        Console.WriteLine("Invalid rate per hour.");
                        continue;
                    }

                    employees[i] = new PT_Emp { Id = id, Name = name, Salary = salary, Hours = hours, RateHour = rateHour };
                }
                else
                {
                    Console.WriteLine("Invalid employee type.");
                    continue;
                }
            }

            Console.WriteLine("\nEmployee Details:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.CalculateSalary()}");
            }
            #endregion


        }
    }
}
