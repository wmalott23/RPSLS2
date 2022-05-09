using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    public class playerCharacter : Player
    {

        public string chooseGesture()
        {
            List<string> choices = new List<string>();
            choices.Add("rock");
            choices.Add("paper");
            choices.Add("scissors");
            choices.Add("lizard");
            choices.Add("spock");

            string input = "";
            while (!choices.Contains(input))
            {
                foreach (var item in choices)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Please enter a gesture from the above list");
            input = Console.ReadLine();
            }
            return input;
        }
    }
}
