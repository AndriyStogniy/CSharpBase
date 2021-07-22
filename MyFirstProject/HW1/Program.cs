using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            //№1 
            Console.WriteLine("Enter first number");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double secondNum = double.Parse(Console.ReadLine());
            double res = firstNum / secondNum;

            //№2
            //2.1
            //Console.WriteLine($"Result = {res:#.##}");
            //2.2
            Console.WriteLine($"Result = {Math.Round(res, 2)}");
*/
            //№3
            long phoneNumber = 19876543210;
            Console.WriteLine(string.Format(format: "{0:+##(###) ###-#1-##}", phoneNumber));
        }
    }
}