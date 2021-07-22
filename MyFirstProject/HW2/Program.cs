using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            Console.Write("Enter a date (e.g. 10/22/1987): ");
            DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
            DateTime independenceDay = new DateTime(1991, 8, 24);

            if (inputtedDate > independenceDay)
                Console.Write("You were born in independent Ukraine");
            else
                Console.Write("You weren't born in independent Ukraine");

            //#2
            Console.Write($"\nsizeof(int) - {sizeof(int)}");

            //#3
            int yearNow = DateTime.Now.Year;
            int yearBorn = inputtedDate.Year;
            int age = yearNow - yearBorn;
            Console.WriteLine($"\nAge - {age}");
            double divRes = (double)age / (double)yearBorn;
            Console.WriteLine($"Division result - {divRes}");

            //#4
            Console.Write("\nHave you a job? (y/n)");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                    Console.WriteLine("It so good");
                    break;
                case "n":
                    Console.WriteLine("Find it");
                    break;
                default:
                    Console.WriteLine("Incorrect ansver");
                    break;
            }


        }
    }
}
