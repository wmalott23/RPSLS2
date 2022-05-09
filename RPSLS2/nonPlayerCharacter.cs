using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    public class nonPlayerCharacter : Player
    {

        public string chooseGesture()
        {
            List<string> choices = new List<string>();
            choices.Add("rock");
            choices.Add("paper");
            choices.Add("scissors");
            choices.Add("lizard");
            choices.Add("spock");
            var random = new Random();
            int index = random.Next(choices.Count);
            string input = choices[index];
            return input;
        }
    }
}
