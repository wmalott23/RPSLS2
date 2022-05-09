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

            List<Gesture> choices = new List<Gesture>();
            choices.Add(rock);
            choices.Add(paper);
            choices.Add(scissors);
            choices.Add(lizard);
            choices.Add(spock);

            


        }
    }
}