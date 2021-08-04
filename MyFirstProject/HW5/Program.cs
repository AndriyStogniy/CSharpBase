using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter game names separated by commas");
            string gameNames = Console.ReadLine();
            string[] gameNamesList = gameNames.Split(",");


            //Array.Reverse(gameNamesList);
            //
            //for (int i = gameNamesList.Length-1; i>=0; i--)
            //{
            //    Console.WriteLine(gameNamesList[i]);
            //}


            Console.WriteLine("Enter a letter to display sorted games");
            char letter = Console.ReadLine()[0];
            foreach(string game in gameNamesList)
            {
                if(game[0] == letter)
                {
                    Console.WriteLine(game);
                }
            }
        }
    }
}
