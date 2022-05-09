using System;
namespace RPSLS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gesture rock = new Gesture();
            rock.winOne = "scissors";
            rock.winOnePhrase = "Rock smashes Scissors";
            rock.winTwo = "Lizard";
            rock.winTwoPhrase = "Rock squishes Lizard";

            Gesture paper = new Gesture();
            paper.winOne = "rock";
            paper.winOnePhrase = "Paper covers Rock";
            paper.winTwo = "spock";
            paper.winTwoPhrase = "Paper disproves Spock";

            Gesture scissors = new Gesture();
            scissors.winOne = "paper";
            scissors.winOnePhrase = "Scissors cuts Paper";
            scissors.winTwo = "lizard";
            scissors.winTwoPhrase = "Scissors decapitates Lizard";

            Gesture lizard = new Gesture();
            lizard.winOne = "spock";
            lizard.winOnePhrase = "Lizard poisons Spock";
            lizard.winTwo = "paper";
            lizard.winTwoPhrase = "Lizard eats Paper";

            Gesture spock = new Gesture();
            spock.winOne = "scissors";
            spock.winOnePhrase = "Spock smashes Scissors";
            spock.winTwo = "rock";
            spock.winTwoPhrase = "Spock vaporizes Rock";

        }
    }
}