using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleGames
{
    /// <summary>
    /// Simple game : player must guess random number between 1 and 100.
    /// </summary>
    public class GuessIT : IGame
    {
        public string Name => "Guess It !";

        public string Description => "The machine find a number between 1 and 100. The player must find the number, in less than 6 tries. The score is 0 if not found, and 5 minus the number of tries if found.";

        public int Run(IConsole console)
        {
            int score = 0;

            Random r = new Random();
            int value = (int)r.NextInt64(1, 100);

            console.Write("I've choose a number between 1 and 100. Try to guess it !");
            bool found = false;
            int tries = 0;
            while(!found && tries<5)
            {
                ++tries;
                string? s = console.ReadLine("Your guess : ");
                int val = Convert.ToInt32(s);
                if(val==value)
                {
                    console.Write("You win !");
                    found = true;
                }
                else if(val<value)
                {
                    console.Write("Too small !");
                }
                else
                {
                    console.Write("Too big !");
                }
            }
            if (found)
                score = 5 - tries;
            else
                console.Write(string.Format("You loose, it was {0}",value));
            return score;
        }
    }
}
