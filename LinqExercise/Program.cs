using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine($"Sum: {numbers.Sum()}");
            Console.WriteLine();

            //TODO: Print the Average of numbers
            Console.WriteLine($"Average: { numbers.Average()}");
            Console.WriteLine();
            //TODO: Order numbers in ascending order and print to the console
            var ascend = numbers.OrderBy(x => x);
            Console.WriteLine("Numbers in ascending order: \n");
            foreach(var x in ascend) 
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            //TODO: Order numbers in decsending order adn print to the console
            var decend = numbers.OrderByDescending(x => x);
            Console.WriteLine("Numbers in decsending order: \n");
            foreach (var x in ascend)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers greter than 6:\n");
            var nums = numbers.Where(x => x > 6);
            foreach( var x in nums) 
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("4 numbers ordered acsending:\n");
            var four = numbers.OrderBy(x => x);
            int counter = 0;
            foreach( var x in four) 
            {
                Console.WriteLine(x);
                counter++;
                if (counter == 4) 
                {
                    break;
                }
            }
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("Values in Descending order and Age at index 4:\n");
            var age = numbers.OrderByDescending(x => x);
            var arr = age.ToArray();
            counter = 0;
            foreach (var x in arr)
            {
                Console.WriteLine(x);
                counter++;
                if (counter == 4)
                {
                    arr[counter] = 26;
                }
            }
            Console.WriteLine();
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            Console.WriteLine("Employess full names starting with S or C in Acesending order: \n");
            var fullName = employees.Where(x => x.FullName.StartsWith("C") || x.FullName.StartsWith("S"));
            fullName = fullName.OrderBy(x => x.FirstName);
            foreach(var x in fullName) 
            {
                Console.WriteLine($"{x.FirstName} {x.LastName}"); 
            }
            Console.WriteLine();


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employess full names with age over 26: \n");
            var fullNameAge = employees.Where(x => x.Age > 26);
            fullNameAge = fullNameAge.OrderBy(x => x.Age);
            fullNameAge = fullNameAge.OrderBy(x => x.FirstName);
            foreach (var x in fullName)
            {
                Console.WriteLine($"{x.FirstName} {x.LastName} Age: {x.Age}");
            }
            Console.WriteLine();
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine("Sum and average of YOE: \n");
            var yoe = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            int sum = 0;
            int average = 0;
            sum = yoe.Sum(x => x.YearsOfExperience);
            average = sum / yoe.Count();

            Console.WriteLine($"Sum of YOE: {sum}\nAvg of YOE: {average}");

            Console.WriteLine();
            //TODO: Add an employee to the end of the list without using employees.Add()
            var person = new Employee("Amr", "Yousry", 26, 5);
            var employeeList = employees.Append(person);

            foreach(Employee employee in employeeList)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
