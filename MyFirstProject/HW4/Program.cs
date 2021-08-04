using System;

namespace HW4
{
    class Program
    {
        static public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static public int Dif(int num1, int num2)
        {
            return num1 - num2;
        }

        static public int Mult(int num1, int num2) => num1 * num2;

        static public int Div(int num1, int num2) => num1 / num2;

        static public void SumAndDif(int num1, int num2, out int sum, out int div)
        {
            sum = num1 + num2;
            div = num1 - num2;
        }

        static public int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1st number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2nd number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Action");
            string act = Console.ReadLine();

            string actions = "+-*/";
            int actIndex = actions.IndexOf(act);
            switch (actIndex)
            {
                case 0:
                    Console.WriteLine(Sum(num1, num2));
                    break;
                case 1:
                    Console.WriteLine(Dif(num1, num2));
                    break;
                case 2:
                    Console.WriteLine(Mult(num1, num2));
                    break;
                case 3:
                    Console.WriteLine(Div(num1, num2));
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.WriteLine("Enter number");
            int factNum = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(factNum));
        }
    }
}
