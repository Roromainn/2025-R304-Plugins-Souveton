using GameBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrapsGame
{
    /// <summary>
    /// Craps game : player throw dices and their values make him win or loose (pure random game)
    /// </summary>
    public class Craps : IGame
    {
        
        public string Name => "Craps";

        public string Description => "Simple dice game, with 2 dices. A winned game gives you 3 points.";

        public int Run(IConsole console)
        {
            int score = 0;
            int first = ThrowDices(console);
            bool perdu = false;
            bool gagne = false;
            if(first==2 || first==3 || first==12)
            {
                perdu = true;
            }
            else if(first==7 || first==11)
            {
                gagne = true;
            }
            else
            {
                while(!gagne && !perdu)
                {
                    int dices = ThrowDices(console);
                    if(dices==first)
                    {
                        gagne = true;
                    }
                    else if(dices==7)
                    {
                        perdu = true;
                    }
                }
            }
            if (gagne)
            {
                score = 3;
                console.Write("You win !");
            }
            else
                console.Write("You loose !");
            return score;
        }

        private int ThrowDices(IConsole console)
        {
            console.Pause("Ready to throw the dices");
            Random r = new Random();
            int dices= (int)(r.NextInt64(1,6)+r.NextInt64(1,6));
            console.Pause(string.Format("dices : {0}", dices));
            return dices;
        }

    }

    public class CreateCraps : ICreateGame
    {
        public IGame CreateGame()
        {
            return new Craps();      
        }
    }
}
