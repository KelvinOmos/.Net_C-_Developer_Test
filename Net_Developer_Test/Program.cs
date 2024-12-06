using System;

namespace DeveloperTest
{
    class Program
    {
        public void Task1()
        {
            // Task 1
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Is Admin: {isAdmin}");
        }

        public void Task2()
        {
            // Task 2
            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        public void Task3()
        {
            // Task 3
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

        }

        public void Task4()
        {
            // Task 4
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
                Console.WriteLine(num);
            }
            Console.WriteLine($"Sum: {sum}");
        }

        // Task 5
        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void Main(string[] args)
        {
            Greet("Alice");
        }
    }
}
