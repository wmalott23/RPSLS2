using System;
namespace RPSLS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gesture rock = new Gesture("scissors", "Lizard");
            Gesture paper = new Gesture("rock", "spock");
            Gesture scissors = new Gesture("paper", "lizard");
            Gesture lizard = new Gesture("spock", "paper");
            Gesture spock = new Gesture("scissors", "rock");

            Console.WriteLine("Greetings Player!");
            string gameType = "";
            while(gameType == "single" | gameType == "multi")
            {
            Console.WriteLine("Would you like a single-player game versus an AI opponent or a multiplayer game with a friend?");
            Console.WriteLine("Please enter `single` for singleplayer and `multi` for multipleayer");
            gameType = Console.ReadLine();
            }
            if (gameType == "single")
            {
                playerCharacter playerOne = new playerCharacter();
                nonPlayerCharacter playerTwo = new nonPlayerCharacter();
            }
            else
            {
                playerCharacter playerOne = new playerCharacter();
                playerCharacter playerTwo = new playerCharacter();
            }

            Console.WriteLine("Player One goes first!");
            string choiceOne = playerOne.chooseGesture();
        }
    }
}