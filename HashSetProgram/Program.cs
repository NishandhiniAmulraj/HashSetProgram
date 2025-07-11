using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> employees = new HashSet<string>
            {
                "Abi",
                "Catherine",
                "Shiny",
                "Abi"
            };

            Console.WriteLine($"Count after adding employees: {employees.Count}"); // Outputs 3

            // Check for existence
            if (employees.Contains("Shiny"))
            {
                Console.WriteLine("Shiny is in the set.");
            }

            // Remove an element
            employees.Remove("Shiny");
            Console.WriteLine($"Count after removal: {employees.Count}"); // Outputs 2

            // Iterate through the set
            Console.WriteLine("List Employees in the set:");
            foreach (var e in employees)
            {
                Console.WriteLine($"- {e}");
            }

        }
    }
}
