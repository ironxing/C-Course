using System;

namespace game
{
    class Program
    {
        static void Main(string[] args) //Körs när programet startas
        {
            string toMatchString = "Tic-Tac-Toe";
            bool toContinue = true;
            Console.WriteLine("Do you want to play a game?");

            while (toContinue) {    
                string userInput = Console.ReadLine();

                if (userInput == toMatchString)
                {
                    Console.WriteLine("A strange game.The only way to win is not to play.");
                    toContinue = false;
                } else
                {
                    Console.WriteLine("I’m sorry, I don’t know that game.");
                }
            }

            Console.ReadKey(); //Avslutas
        }
    }
}
