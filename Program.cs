using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Welcome to c#");
            //      Console.ReadKey();
            //DataType variableName

            //Exsmple 2
            // string firstName;
            //  string lastName;
            //  Console.WriteLine("Enter first name");
            // firstName = Console.ReadLine();
            //  Console.WriteLine("Enter last name");

            //  lastName = Console.ReadLine();
            // Console.WriteLine("Welcome Mr. \\Ms.  "  +firstName+" "+lastName);
            // Console.ReadKey();

            // Example 3

            string name;
            int age;
            char grade;
            DateTime doj;
            double salary;
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade");
            grade = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter date of joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Name : \t" + name + "\n Age: " + age + "\n Grade: \t " + grade + "\n salary: \t  " + salary + "\n Date of joining: \t " + doj);
            Console.ReadKey();


        }
    }
}
