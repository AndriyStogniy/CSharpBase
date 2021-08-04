using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            string choiceString;
            Random rnd = new Random();
            for(; ; )
            {
                Console.WriteLine("Please choose the door from 1 to 5");
                choiceString = Console.ReadLine();
                if(choiceString == "Exit")
                {
                    break;
                }
                else
                {
                    int res;
                    bool intCheck = int.TryParse(choiceString, out res);
                    if (intCheck && res <= 5 && res >=1)
                    {
                        int choice = rnd.Next(1, 5);
                        if(res == choice)
                        {
                            Console.WriteLine("There is a treasure. You win!");
                        }
                        else
                        {
                            Console.WriteLine("There is an enemy. You loose!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: You need enter number from 1 to 5!!!");
                    }
                }
            }


            //{
            //    Random rnd = new Random();
            //    int choice = rnd.Next(1, 5);

            //    switch (choice)
            //    {
            //     if (choice == 1)
            //                Console.WriteLine("There is an enemy. You loose!");
            //            break;
            //        case 2:
            //            Console.WriteLine("There is a treasure. You win!");
            //    }
            //}
        }
    }
}
